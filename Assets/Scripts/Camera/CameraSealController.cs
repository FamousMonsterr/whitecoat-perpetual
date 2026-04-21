using UnityEngine;
using Unity.Cinemachine;

[RequireComponent(typeof(CinemachineCamera))]
public class CameraSealController : MonoBehaviour
{
    public Transform followTarget;
    public float baseDamping = 0.8f;
    public float depthDampingMultiplier = 0.3f;
    public float speedFOVBoost = 8f;
    public float baseFOV = 45f;

    private CinemachineCamera vcam;
    private CinemachineThirdPersonFollow thirdPersonFollow;
    private CinemachineFollow cinemachineFollow;

    void Awake()
    {
        vcam = GetComponent<CinemachineCamera>();

        if (followTarget != null)
        {
            vcam.Follow = followTarget;
            vcam.LookAt = followTarget;
        }

        // В Cinemachine 3.x компоненты Body добавляются на тот же GameObject.
        // CinemachineThirdPersonFollow — рекомендуемый компонент для 3rd-person камеры.
        // Документация: https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/api/Unity.Cinemachine.CinemachineThirdPersonFollow.html
        thirdPersonFollow = GetComponent<CinemachineThirdPersonFollow>();
        if (thirdPersonFollow == null)
        {
            // Fallback: если ThirdPersonFollow отсутствует, пробуем CinemachineFollow
            // и используем TrackerSettings.PositionDamping
            // Документация: https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/api/Unity.Cinemachine.CinemachineFollow.html
            cinemachineFollow = GetComponent<CinemachineFollow>();
        }

        ApplyInitialSettings();
    }

    void ApplyInitialSettings()
    {
        if (thirdPersonFollow != null)
        {
            thirdPersonFollow.CameraDistance = 6f;
            thirdPersonFollow.VerticalOffset = 2.5f;
            thirdPersonFollow.Damping = new Vector3(baseDamping, baseDamping, baseDamping);
        }
        else if (cinemachineFollow != null)
        {
            cinemachineFollow.TrackerSettings.PositionDamping = new Vector3(baseDamping, baseDamping, baseDamping);
        }
    }

    void Update()
    {
        if (vcam == null || followTarget == null) return;

        float depth = Mathf.Max(0, -followTarget.position.y);
        Rigidbody rb = followTarget.GetComponent<Rigidbody>();
        float speed = rb != null ? rb.linearVelocity.magnitude : 0f;

        float damping = Mathf.Lerp(baseDamping, depthDampingMultiplier, Mathf.Clamp01(depth / 40f));

        if (thirdPersonFollow != null)
        {
            thirdPersonFollow.Damping = new Vector3(damping, damping, damping);
        }
        else if (cinemachineFollow != null)
        {
            cinemachineFollow.TrackerSettings.PositionDamping = new Vector3(damping, damping, damping);
        }

        float targetFOV = baseFOV + speed * speedFOVBoost;
        vcam.Lens.FieldOfView = Mathf.Lerp(vcam.Lens.FieldOfView, targetFOV, Time.deltaTime * 3f);
    }
}
