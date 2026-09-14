using UnityEngine;

/// <summary>
/// Процедурная анимация белька поверх FBX-клипов: выбор состояния + кроссфейды.
/// Клипы приходят из Blender (SealSwim, SealIdle, SealWaddle, SealBark, SealEat).
/// </summary>
[RequireComponent(typeof(Animation))]
public class SealAnimatorDriver : MonoBehaviour
{
    private Animation _anim;
    private SealController _seal;
    private SealStats _stats;
    private string _current = "SealIdle";
    private float _barkUntil;
    private float _eatUntil;
    private bool _wasAbove;

    private static readonly string Swim = "SealSwim";
    private static readonly string Idle = "SealIdle";
    private static readonly string Waddle = "SealWaddle";
    private static readonly string Bark = "SealBark";
    private static readonly string Eat = "SealEat";

    private void Awake()
    {
        _anim = GetComponent<Animation>();
        _seal = GetComponent<SealController>();
        _stats = GetComponent<SealStats>();
    }

    private void Start()
    {
        foreach (AnimationState st in _anim)
            if (st != null) st.speed = 1f;
        if (_anim[Idle] != null) { _anim[Idle].wrapMode = WrapMode.Loop; _anim.Play(Idle); _current = Idle; }
        if (_anim[Swim] != null) _anim[Swim].wrapMode = WrapMode.Loop;
        if (_anim[Waddle] != null) _anim[Waddle].wrapMode = WrapMode.Loop;
        if (_anim[Bark] != null) _anim[Bark].wrapMode = WrapMode.Once;
        if (_anim[Eat] != null) _anim[Eat].wrapMode = WrapMode.Once;
        GameEvents.OnBarked += OnBarked;
        GameEvents.OnAte += OnAte;
    }

    private void OnDestroy()
    {
        GameEvents.OnBarked -= OnBarked;
        GameEvents.OnAte -= OnAte;
    }

    private void OnBarked() => _barkUntil = Time.time + 0.9f;
    private void OnAte() => _eatUntil = Time.time + 0.8f;

    private void Update()
    {
        if (_anim == null || _seal == null) return;
        float speed = _seal.Velocity.magnitude;
        bool above = !_seal.Underwater;

        string want;
        if (Time.time < _barkUntil) want = Bark;
        else if (Time.time < _eatUntil) want = Eat;
        else if (_seal.Underwater)
            want = speed > 0.6f ? Swim : Idle;
        else if (above && speed > 0.4f) want = Waddle;
        else want = Idle;

        // Скорость плавания синхронизируем с движением
        if (_anim[Swim] != null)
            _anim[Swim].speed = Mathf.Clamp(0.6f + speed * 0.35f, 0.6f, 2.2f);

        if (want != _current)
        {
            _anim.CrossFade(want, 0.22f);
            _current = want;
        }
    }
}
