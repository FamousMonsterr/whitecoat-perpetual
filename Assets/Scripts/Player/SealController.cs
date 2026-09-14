using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Контроллер белька: плавание с плавучестью, передвижение по льду, увороты,
/// лай (эхолокация), дыхание в лунках и на поверхности.
/// Физика: Rigidbody forces — стабильные при 60fps и при timeScale=0.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class SealController : MonoBehaviour
{
    public static SealController Instance { get; private set; }

    [Header("Точка головы (для дыхания)")]
    public Transform headPoint;

    [Header("Крутящие моменты")]
    public float pitchPower = 55f;
    public float rollBankAmount = 22f;

    public bool Underwater { get; private set; }
    public bool IsSwimmingFast { get; private set; }
    public bool OnIce { get; private set; }
    public bool CanBreatheNow { get; private set; }
    public bool Dodging { get; private set; }
    public float Depth { get; private set; }
    public Vector3 Velocity => _rb != null ? _rb.linearVelocity : Vector3.zero;

    private Rigidbody _rb;
    private CapsuleCollider _col;
    private InputRouter _input;
    private SealStats _stats;
    private OceanManager _ocean;
    private WeatherSystem _weather;
    private Camera _cam;
    private float _dodgeTimer;
    private float _barkCooldown;
    private float _eatAnimTimer;
    private float _depthReportTimer;
    private bool _invulnerable;

    private void Awake()
    {
        Instance = this;
        _rb = GetComponent<Rigidbody>();
        _col = GetComponent<CapsuleCollider>();
        _rb.mass = 1f;
        _rb.linearDamping = 0f;
        _rb.angularDamping = 4f;
        _rb.interpolation = RigidbodyInterpolation.Interpolate;
        _rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        _rb.constraints = RigidbodyConstraints.FreezeRotationZ; // крен контролируем сами
    }

    private void OnDestroy() { if (Instance == this) Instance = null; }

    private void Start()
    {
        _input = InputRouter.Instance;
        _stats = GetComponent<SealStats>();
        _ocean = OceanManager.Instance;
        _weather = FindFirstObjectByType<WeatherSystem>();
        _cam = Camera.main;
    }

    private void Update()
    {
        _barkCooldown -= Time.deltaTime;
        _eatAnimTimer -= Time.deltaTime;

        if (InputRouter.Instance != null && InputRouter.Instance.ConsumeBark() &&
            _barkCooldown <= 0f && GameManager.Instance != null &&
            GameManager.Instance.State == GameManager.GameState.Playing)
        {
            _barkCooldown = GameConfig.BarkCooldown;
            DoBark();
        }

        // Плавучесть-дышимость пересчитываем каждый кадр
        UpdateBreathing();
    }

    private void FixedUpdate()
    {
        if (GameManager.Instance == null ||
            (GameManager.Instance.State != GameManager.GameState.Playing &&
             GameManager.Instance.State != GameManager.GameState.Evolution))
        {
            return;
        }

        Vector3 move = _input != null ? _input.MoveVector : Vector3.zero;
        float dive = _input != null ? _input.DiveInput : 0f;
        bool boost = _input != null && _input.BoostHeld;
        bool dodge = _input != null && InputRouter.Instance.ConsumeDodge();

        float waterY = _ocean != null ? _ocean.WaterLevelNow(transform.position) : GameConfig.WaterLevel;
        Underwater = transform.position.y < waterY - 0.05f;
        Depth = Mathf.Max(0f, waterY - transform.position.y);
        IsSwimmingFast = Underwater && boost && _stats != null && _stats.stamina > 1f;

        // Опора: лёд под телом?
        UpdateGrounded();

        if (Underwater && !OnIce) SwimPhysics(move, dive, boost);
        else LandPhysics(move);

        if (dodge && _stats != null && _stats.stamina >= GameConfig.DodgeStaminaCost * DodgeCost())
            DoDodge(move);

        UpdateDepthReporting();
    }

    // ---------------- ВОДА ----------------
    private void SwimPhysics(Vector2 move, float dive, bool boost)
    {
        float speedGene = _stats != null && _stats.Genes != null ? _stats.Genes.SpeedMult : 1f;
        float target = boost ? GameConfig.SwimBoostSpeed * speedGene : GameConfig.SwimSpeed * speedGene;

        // Камера-относительное направление в горизонтальной плоскости
        Vector3 dir = CameraRelative(move);
        Vector3 targetVel = dir * target;

        // Вертикаль: нырок/всплытие + плавучесть к поверхности
        float waterY = _ocean != null ? _ocean.WaterLevelNow(transform.position) : 0f;
        float submersion = _ocean != null ? _ocean.Submersion(transform.position, _col.radius * 1.2f) : 1f;
        float buoy = 0f;
        if (dive > 0.1f) buoy = -GameConfig.SinkForce * dive;               // нырок вниз
        else if (dive < -0.1f) buoy = GameConfig.BuoyancyForce * 1.4f;      // всплытие
        else
        {
            // пассивная плавучесть: держаться чуть ниже поверхности
            float targetDepth = 0.28f;
            float err = (transform.position.y - (waterY - targetDepth));
            buoy = -err * GameConfig.BuoyancyForce * submersion * 0.8f;
        }

        // Двигаемся к целевой скорости (вода даёт демпфирование)
        Vector3 vel = _rb.linearVelocity;
        Vector3 velDelta = (targetVel - new Vector3(vel.x, 0, vel.z)) * (GameConfig.SwimAcceleration * Time.fixedDeltaTime);
        vel.x += velDelta.x; vel.z += velDelta.z;
        vel.y += buoy * Time.fixedDeltaTime;
        // Вертикальный демпфер
        vel.y *= (1f - Mathf.Min(1f, 2.2f * Time.fixedDeltaTime));

        if (_stats != null)
        {
            // стамина буста
            if (IsSwimmingFast)
            {
                _stats.stamina -= GameConfig.BoostStaminaPerSec * Time.fixedDeltaTime;
                if (_stats.stamina < 0f) { _stats.stamina = 0f; IsSwimmingFast = false; }
            }
            else
                _stats.stamina = Mathf.Min(GameConfig.BaseStamina,
                    _stats.stamina + GameConfig.StaminaRegenPerSec * Time.fixedDeltaTime);
            _stats.underwater = true;
            _stats.onIce = false;
            _stats.depth = Depth;
        }

        _rb.linearVelocity = vel;

        // Ориентация: нос по движению, крен в поворот, тангаж по вертикальной скорости
        if (vel.sqrMagnitude > 0.4f)
        {
            Vector3 lookDir = vel; lookDir.y = 0f;
            if (lookDir.sqrMagnitude > 0.05f)
            {
                Quaternion targetRot = Quaternion.LookRotation(lookDir.normalized, Vector3.up);
                float agi = _stats != null && _stats.Genes != null ? _stats.Genes.AgilityMult : 1f;
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot,
                    GameConfig.TurnResponsiveness * agi * Time.fixedDeltaTime);
            }
        }
        float pitch = Mathf.Clamp(-vel.y * pitchPower * 0.12f, -28f, 28f);
        Vector3 euler = transform.eulerAngles;
        transform.rotation = Quaternion.Slerp(transform.rotation,
            Quaternion.Euler(euler.x * 0f + pitch, transform.eulerAngles.y, 0f),
            Time.fixedDeltaTime * 2.5f);
    }

    // ---------------- ЛЁД ----------------
    private void LandPhysics(Vector2 move)
    {
        Vector3 dir = CameraRelative(move);
        Vector3 targetVel = new Vector3(dir.x, 0, dir.z) * GameConfig.WaddleSpeed;
        Vector3 vel = _rb.linearVelocity;
        vel.x = Mathf.Lerp(vel.x, targetVel.x, 8f * Time.fixedDeltaTime);
        vel.z = Mathf.Lerp(vel.z, targetVel.z, 8f * Time.fixedDeltaTime);

        if (_stats != null)
        {
            _stats.underwater = false;
            _stats.onIce = OnIce;
            _stats.depth = 0f;
            _stats.stamina = Mathf.Min(GameConfig.BaseStamina,
                _stats.stamina + GameConfig.StaminaRegenPerSec * Time.fixedDeltaTime);
        }

        _rb.linearVelocity = vel;

        if (dir.sqrMagnitude > 0.05f)
        {
            Quaternion targetRot = Quaternion.LookRotation(new Vector3(dir.x, 0, dir.z).normalized, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, 6f * Time.fixedDeltaTime);
        }
    }

    private void UpdateGrounded()
    {
        Vector3 origin = transform.position + Vector3.up * 0.4f;
        OnIce = Physics.Raycast(origin, Vector3.down, out var hit, 1.1f, 1 << LayerMask.NameToLayer("Ice"));
    }

    private void UpdateBreathing()
    {
        Vector3 head = headPoint != null ? headPoint.position : transform.position + Vector3.up * 0.25f;
        float waterY = _ocean != null ? _ocean.WaterLevelNow(head) : GameConfig.WaterLevel;
        bool headAboveWater = head.y > waterY;
        bool iceAbove = Physics.Raycast(head, Vector3.up, 2.6f, 1 << LayerMask.NameToLayer("Ice"));
        bool inHole = BreathingHole.IsInAnyHole(head);
        CanBreatheNow = headAboveWater && (!iceAbove || inHole);
    }

    // ---------------- ДЕЙСТВИЯ ----------------
    private float DodgeCost() =>
        (_stats != null && _stats.Genes != null) ? _stats.Genes.DodgeCostMult : 1f;

    private void DoDodge(Vector2 move)
    {
        Vector3 dir = CameraRelative(move);
        if (dir.sqrMagnitude < 0.1f) dir = transform.forward;
        _rb.AddForce(dir.normalized * GameConfig.DodgeImpulse + Vector3.up * 2.2f, ForceMode.VelocityChange);
        if (_stats != null) _stats.stamina -= GameConfig.DodgeStaminaCost * DodgeCost();
        _dodgeTimer = 0.6f;
        Dodging = true;
        Invoke(nameof(EndDodge), 0.6f);
        AudioDirector.PlaySfx("swish", transform.position);
    }

    private void EndDodge() => Dodging = false;

    public bool IsInvulnerable => _dodgeTimer > 0f;

    private void DoBark()
    {
        _eatAnimTimer = 0.8f;
        AudioDirector.PlaySfx("bark", transform.position);
        GameEvents.RaiseBarked();
        // Касатка слышит лай
        var orca = OrcaAgent.ActiveOrca;
        if (orca != null && Vector3.Distance(orca.transform.position, transform.position) < GameConfig.BarkAlertOrcaRadius)
            orca.HearBark(transform.position);
    }

    /// <summary>Съесть что-то (вызывают FoodPickup/FishSchool).</summary>
    public void TryEat(FoodType type)
    {
        _eatAnimTimer = 0.7f;
        AudioDirector.PlaySfx("eat", transform.position);
        float fm = _stats != null && _stats.Genes != null ? _stats.Genes.FoodMult : 1f;
        switch (type)
        {
            case FoodType.Fish:
                _stats?.Eat(GameConfig.FishHungerValue * fm, GameConfig.XPPerFish, GameConfig.XPPerFish);
                break;
            case FoodType.Krill:
                _stats?.Eat(GameConfig.KrillHungerValue * fm, GameConfig.XPPerKrill, GameConfig.XPPerKrill);
                break;
            case FoodType.Clam:
                _stats?.Eat(GameConfig.ClamHungerValue * fm, GameConfig.XPPerClam, GameConfig.XPPerClam);
                break;
        }
    }

    private void UpdateDepthReporting()
    {
        _depthReportTimer -= Time.fixedDeltaTime;
        if (_depthReportTimer <= 0f)
        {
            _depthReportTimer = 1f;
            GameManager.Instance?.ReportDepth(Depth);
        }
    }

    private Vector3 CameraRelative(Vector2 move)
    {
        if (move.sqrMagnitude < 0.001f) return Vector3.zero;
        if (_cam == null) _cam = Camera.main;
        Vector3 f = _cam != null ? _cam.transform.forward : transform.forward;
        Vector3 r = _cam != null ? _cam.transform.right : transform.right;
        f.y = 0; r.y = 0;
        f.Normalize(); r.Normalize();
        return (f * move.y + r * move.x).normalized;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(headPoint != null ? headPoint.position : transform.position, 0.2f);
    }
}

public enum FoodType { Fish, Krill, Clam }
