using UnityEngine;

/// <summary>
/// Адаптивный ИИ касатки: Patrol → Stalk → Chase → Lunge → Retreat.
/// Учитывает видимость (погода), лай белька, увороты, дыхание у поверхности.
/// </summary>
public class OrcaAgent : MonoBehaviour
{
    public static OrcaAgent ActiveOrca { get; private set; }

    public enum State { Patrol, Stalk, Chase, Lunge, Retreat }

    public State Current { get; private set; } = State.Patrol;

    [Header("Компоненты")]
    public Animation anim;

    private Transform _target;
    private SealController _seal;
    private Rigidbody _rb;
    private WeatherSystem _weather;
    private OceanManager _ocean;
    private float _stateTimer;
    private float _giveUpTimer;
    private Vector3 _patrolPoint;
    private Vector3 _homeBase;

    public float DistanceToSeal =>
        _seal != null ? Vector3.Distance(transform.position, _seal.transform.position) : float.MaxValue;

    private void Awake()
    {
        ActiveOrca = this;
        _rb = GetComponent<Rigidbody>();
        _rb.useGravity = false;
        _rb.linearDamping = 1.2f;
        _rb.angularDamping = 3f;
    }

    private void OnDestroy() { if (ActiveOrca == this) ActiveOrca = null; }

    private void Start()
    {
        _seal = SealController.Instance;
        if (_seal != null) _target = _seal.transform;
        _weather = FindAnyObjectByType<WeatherSystem>();
        _ocean = OceanManager.Instance;
        _homeBase = transform.position;
        NewPatrolPoint();
        if (anim != null && anim["OrcaCruise"] != null)
        {
            anim["OrcaCruise"].wrapMode = WrapMode.Loop;
            anim["OrcaChase"].wrapMode = WrapMode.Loop;
            anim["OrcaLunge"].wrapMode = WrapMode.Once;
            anim.Play("OrcaCruise");
        }
    }

    public void HearBark(Vector3 pos)
    {
        if (Current == State.Patrol && DistanceToSeal < GameConfig.BarkAlertOrcaRadius)
        {
            Current = State.Stalk;
            _stateTimer = 4f;
            NewStalkPoint();
        }
    }

    private float DetectRange =>
        GameConfig.OrcaDetectRange *
        (_weather != null ? Mathf.Lerp(1.15f, 0.35f, 1f - _weather.Visibility01) : 1f);

    private void Update()
    {
        if (_seal == null) { _seal = SealController.Instance; if (_seal != null) _target = _seal.transform; }
        _stateTimer -= Time.deltaTime;

        switch (Current)
        {
            case State.Patrol: UpdatePatrol(); break;
            case State.Stalk: UpdateStalk(); break;
            case State.Chase: UpdateChase(); break;
            case State.Lunge: UpdateLunge(); break;
            case State.Retreat: UpdateRetreat(); break;
        }

        // Ориентация корпуса
        if (_rb.linearVelocity.sqrMagnitude > 0.3f)
        {
            Vector3 look = _rb.linearVelocity; look.y = 0f;
            if (look.sqrMagnitude > 0.05f)
                transform.rotation = Quaternion.Slerp(transform.rotation,
                    Quaternion.LookRotation(look.normalized, Vector3.up), 3.5f * Time.deltaTime);
        }

        GameEvents.RaiseThreat(ThreatLevel());
    }

    private float ThreatLevel()
    {
        float d = DistanceToSeal;
        float baseT = Mathf.Clamp01(1f - d / DetectRange);
        switch (Current)
        {
            case State.Chase: return Mathf.Max(baseT, 0.8f);
            case State.Lunge: return 1f;
            case State.Stalk: return Mathf.Max(baseT * 0.8f, 0.35f);
            default: return baseT * 0.5f;
        }
    }

    // ---------------- Состояния ----------------
    private void UpdatePatrol()
    {
        SwimTowards(_patrolPoint, GameConfig.OrcaPatrolSpeed, "OrcaCruise");
        if (Vector3.Distance(transform.position, _patrolPoint) < 5f || _stateTimer <= 0f)
        {
            NewPatrolPoint();
            _stateTimer = Random.Range(8f, 16f);
        }
        // Обнаружение
        if (_target != null && DistanceToSeal < DetectRange && SealInWater())
        {
            Current = State.Stalk;
            _stateTimer = Random.Range(5f, 9f);
            NewStalkPoint();
            AudioDirector.PlaySfx("orca_call", transform.position);
        }
    }

    private void UpdateStalk()
    {
        // Кружим на границе обнаружения, ждём момент
        Vector3 toSeal = SealPos() - transform.position;
        Vector3 orbit = toSeal - toSeal.normalized * DetectRange * 0.55f;
        Vector3 tangent = Vector3.Cross(toSeal.normalized, Vector3.up) * 14f;
        SwimTowards(orbit + tangent, GameConfig.OrcaPatrolSpeed * 1.3f, "OrcaCruise");

        bool goodMoment = _seal != null &&
                          (_seal.Depth > 4f || !_seal.CanBreatheNow); // бельк глубоко или без воздуха
        if (DistanceToSeal < DetectRange * 0.5f && goodMoment && SealInWater())
        {
            Current = State.Chase;
            _giveUpTimer = GameConfig.OrcaChaseGiveUpSec;
            AudioDirector.PlaySfx("orca_danger", transform.position);
        }
        else if (_stateTimer <= 0f || DistanceToSeal > DetectRange * 1.4f)
        {
            Current = State.Patrol;
            _stateTimer = 8f;
            NewPatrolPoint();
        }
    }

    private void UpdateChase()
    {
        _giveUpTimer -= Time.deltaTime;
        SwimTowards(SealPos(), GameConfig.OrcaChaseSpeed, "OrcaChase");

        if (DistanceToSeal < GameConfig.OrcaAttackRange)
        {
            Current = State.Lunge;
            _stateTimer = 0.9f;
            if (anim != null && anim["OrcaLunge"] != null) anim.CrossFade("OrcaLunge", 0.1f);
            TryBite();
        }
        else if (_giveUpTimer <= 0f || SealSafe())
        {
            Current = State.Retreat;
            _stateTimer = GameConfig.OrcaRetreatSec;
        }
    }

    private void UpdateLunge()
    {
        SwimTowards(SealPos(), GameConfig.OrcaChaseSpeed * 1.35f, null);
        if (_stateTimer <= 0f)
        {
            Current = State.Chase;
            _giveUpTimer = Mathf.Max(2f, _giveUpTimer);
        }
    }

    private void UpdateRetreat()
    {
        Vector3 away = transform.position + (transform.position - SealPos()).normalized * 60f;
        SwimTowards(away, GameConfig.OrcaPatrolSpeed * 1.6f, "OrcaCruise");
        if (_stateTimer <= 0f || DistanceToSeal > 70f)
        {
            Current = State.Patrol;
            _stateTimer = 10f;
            _homeBase = SealPos() + new Vector3(Random.Range(-60, 60), -6f, Random.Range(-60, 60));
            _homeBase.y = Mathf.Clamp(_homeBase.y, -18f, -4f);
            NewPatrolPoint();
        }
    }

    // ---------------- Механика ----------------
    private void TryBite()
    {
        if (_seal == null) return;
        if (_seal.IsInvulnerable) return; // успешный уворот!
        float dist = DistanceToSeal;
        if (dist < GameConfig.OrcaAttackRange * 1.15f)
        {
            _seal.GetComponent<SealStats>()?.Damage(GameConfig.OrcaBiteDamage, "death_orca");
            // Отбросить белька
            Vector3 knock = (_seal.transform.position - transform.position).normalized;
            _seal.GetComponent<Rigidbody>().AddForce(knock * 11f + Vector3.up * 4f, ForceMode.VelocityChange);
            AudioDirector.PlaySfx("bite", transform.position);
            Current = State.Retreat;
            _stateTimer = GameConfig.OrcaRetreatSec;
        }
    }

    private void SwimTowards(Vector3 target, float speed, string clipName)
    {
        Vector3 desired = target - transform.position;
        float targetDepth = desired.y;
        desired.y = 0f;
        // Ограничение глубины касатки: не глубже 22м, не выше поверхности
        Vector3 pos = transform.position;
        float minY = GameConfig.SeaFloorY + 3f;
        float maxY = -1.2f;
        Vector3 vel = _rb.linearVelocity;
        Vector3 dir = desired.sqrMagnitude > 0.01f ? desired.normalized : Vector3.zero;
        float vertical = Mathf.Clamp(targetDepth, -1f, 1f) * speed * 0.7f;
        if (pos.y > maxY) vertical = Mathf.Min(vertical, -1.5f);
        if (pos.y < minY) vertical = Mathf.Max(vertical, 1.5f);
        Vector3 targetVel = dir * speed + new Vector3(0, vertical, 0);
        _rb.linearVelocity = Vector3.Lerp(vel, targetVel, 2.2f * Time.deltaTime);

        if (!string.IsNullOrEmpty(clipName) && anim != null && anim.GetClip(clipName) != null &&
            anim.IsPlaying(clipName) == false)
            anim.CrossFade(clipName, 0.25f);
    }

    private Vector3 SealPos() => _target != null ? _target.position : Vector3.zero;

    private bool SealInWater() => _seal != null && _seal.Underwater;

    private bool SealSafe() =>
        _seal != null && (_seal.OnIce || (!_seal.Underwater && _seal.CanBreatheNow && Random.value < 0.02f));

    private void NewPatrolPoint()
    {
        Vector3 baseP = _seal != null ? _seal.transform.position : _homeBase;
        _patrolPoint = baseP + new Vector3(Random.Range(-45, 45), Random.Range(-14, -3), Random.Range(-45, 45));
        _patrolPoint.y = Mathf.Clamp(_patrolPoint.y, GameConfig.SeaFloorY + 4f, -2.5f);
        _stateTimer = Mathf.Max(_stateTimer, 6f);
    }

    private void NewStalkPoint()
    {
        Vector3 p = SealPos() + new Vector3(Random.Range(-20, 20), Random.Range(-6, 2), Random.Range(-20, 20));
        p.y = Mathf.Clamp(p.y, GameConfig.SeaFloorY + 4f, -2.5f);
        _patrolPoint = p;
    }

    private void OnDrawGizmos()
    {
        switch (Current)
        {
            case State.Chase: Gizmos.color = Color.red; break;
            case State.Stalk: Gizmos.color = Color.yellow; break;
            case State.Lunge: Gizmos.color = new Color(1f, 0.2f, 0f); break;
            default: Gizmos.color = Color.cyan; break;
        }
        Gizmos.DrawWireSphere(transform.position, 1f);
    }
}
