using UnityEngine;

/// <summary>
/// Декоративный пловец по круговой орбите (CC0-киты на горизонте, рифовые рыбы).
/// Компонент вешается на PIVOT; визуальная модель — ребёнок со своей базовой
/// ориентацией (повороты модели не затираются логикой движения).
/// Заморожен в MainMenu (Time.timeScale = 0) — это нормально.
/// </summary>
public class AmbientSwimmer : MonoBehaviour
{
    [Header("Орбита")]
    public Vector3 center = Vector3.zero;
    public float radius = 40f;
    public float angularSpeed = 0.08f; // рад/с (полный круг ~80 c)
    public float phase = 0f;

    [Header("Дыхание/качка")]
    public float bobAmp = 0.3f;
    public float bobSpeed = 0.35f;

    [Header("Ориентация")]
    public float yawOffset = 0f; // если модель смотрит не в +Z
    public float turnLerp = 2.5f;

    private float _t;
    private Vector3 _lastPos;
    private bool _first = true;

    private void Start()
    {
        _t = phase;
        // Анимация (Swim у CC0-моделей) уже играет автоматически через Animation,
        // но на случай playAutomatically=false — подстрахуемся.
        var anim = GetComponentInChildren<Animation>();
        if (anim != null && anim.clip != null && !anim.isPlaying) anim.Play();
    }

    private void Update()
    {
        _t += angularSpeed * Time.deltaTime;
        Vector3 p = center + new Vector3(
            Mathf.Cos(_t) * radius,
            Mathf.Sin(_t * bobSpeed + phase) * bobAmp,
            Mathf.Sin(_t) * radius);
        transform.position = p;

        if (!_first)
        {
            Vector3 vel = p - _lastPos;
            if (vel.sqrMagnitude > 1e-8f)
            {
                var target = Quaternion.LookRotation(vel.normalized, Vector3.up)
                             * Quaternion.Euler(0f, yawOffset, 0f);
                transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * turnLerp);
            }
        }
        _lastPos = p;
        _first = false;
    }
}
