using UnityEngine;
using Unity.Cinemachine;

/// <summary>
/// Кинематографичная камера на Cinemachine 3.x: демпфирование по глубине,
/// FOV по скорости, подводная «плотность», лёгкий датч при угрозе.
/// </summary>
[RequireComponent(typeof(CinemachineCamera))]
public class CameraSealController : MonoBehaviour
{
    public Transform followTarget;
    public float baseDamping = 0.8f;
    public float depthDampingMultiplier = 0.3f;
    public float speedFOVBoost = 8f;
    public float baseFOV = 45f;
    public float underwaterFOV = 38f;

    private CinemachineCamera _vcam;
    private CinemachineThirdPersonFollow _thirdPersonFollow;
    private CinemachineFollow _cinemachineFollow;
    private OceanManager _ocean;
    private float _threatShake;

    private void Awake()
    {
        _vcam = GetComponent<CinemachineCamera>();
        if (followTarget != null)
        {
            _vcam.Follow = followTarget;
            _vcam.LookAt = followTarget;
        }
        _thirdPersonFollow = GetComponent<CinemachineThirdPersonFollow>();
        if (_thirdPersonFollow == null)
            _cinemachineFollow = GetComponent<CinemachineFollow>();
        ApplyInitialSettings();
        _ocean = OceanManager.Instance;
    }

    private void OnEnable()
    {
        GameEvents.OnThreatLevel += HandleThreat;
    }

    private void OnDisable()
    {
        GameEvents.OnThreatLevel -= HandleThreat;
    }

    private void HandleThreat(float t)
    {
        _threatShake = t;
    }

    private void ApplyInitialSettings()
    {
        if (_thirdPersonFollow != null)
        {
            _thirdPersonFollow.CameraDistance = 6f;
            _thirdPersonFollow.VerticalOffset = 2.5f;
            _thirdPersonFollow.Damping = new Vector3(baseDamping, baseDamping, baseDamping);
        }
        else if (_cinemachineFollow != null)
        {
            _cinemachineFollow.TrackerSettings.PositionDamping =
                new Vector3(baseDamping, baseDamping, baseDamping);
        }
    }

    private void Update()
    {
        if (_vcam == null || followTarget == null) return;
        if (_ocean == null) _ocean = OceanManager.Instance;

        float depth = Mathf.Max(0, -followTarget.position.y);
        var rb = followTarget.GetComponent<Rigidbody>();
        float speed = rb != null ? rb.linearVelocity.magnitude : 0f;
        bool under = _ocean != null && _ocean.IsUnderwater(_vcam.transform.position);

        float damping = Mathf.Lerp(baseDamping, depthDampingMultiplier, Mathf.Clamp01(depth / 40f));
        if (_thirdPersonFollow != null)
        {
            _thirdPersonFollow.Damping = new Vector3(damping, damping, damping);
            _thirdPersonFollow.CameraDistance = Mathf.Lerp(6f, 5.2f, Mathf.Clamp01(depth / 30f));
        }
        else if (_cinemachineFollow != null)
        {
            _cinemachineFollow.TrackerSettings.PositionDamping = new Vector3(damping, damping, damping);
        }

        // FOV: скорость + подводная «плотность»
        float targetFOV = (under ? underwaterFOV : baseFOV) + speed * speedFOVBoost * 0.5f;
        _vcam.Lens.FieldOfView = Mathf.Lerp(_vcam.Lens.FieldOfView, targetFOV, Time.deltaTime * 3f);

        // Датч-дрожь при высокой угрозе
        if (_threatShake > 0.5f)
        {
            _vcam.Lens.Dutch = Mathf.Sin(Time.time * 37f) * 1.6f * _threatShake;
        }
        else
        {
            _vcam.Lens.Dutch = Mathf.Lerp(_vcam.Lens.Dutch, 0f, Time.deltaTime * 4f);
        }
    }
}
