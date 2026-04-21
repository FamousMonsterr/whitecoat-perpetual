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
    // В Cinemachine 3.x для управления damping используется CinemachineThirdPersonFollow
    // Документация: https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/api/Unity.Cinemachine.CinemachineThirdPersonFollow.html
    private CinemachineThirdPersonFollow thirdPersonFollow;

    void Awake() {
        vcam = GetComponent<CinemachineCamera>();
        
        if (followTarget != null) {
            vcam.Follow = followTarget;
            vcam.LookAt = followTarget;
        }
        
        // Получаем компонент ThirdPersonFollow вместо Follow
        thirdPersonFollow = vcam.GetComponent<CinemachineThirdPersonFollow>();
        if (thirdPersonFollow != null) {
            thirdPersonFollow.CameraDistance = 6f;
            thirdPersonFollow.VerticalOffset = 2.5f;
            // В Cinemachine 3.x свойство BodyDamping управляет плавностью следования
            // Документация: https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/api/Unity.Cinemachine.CinemachineThirdPersonFollow.html#Unity_Cinemachine_CinemachineThirdPersonFollow_BodyDamping
            thirdPersonFollow.BodyDamping = new Vector3(baseDamping, baseDamping, baseDamping);
        }
    }

    void Update() {
        if (vcam == null || followTarget == null) return;
        
        float depth = Mathf.Max(0, -followTarget.position.y);
        Rigidbody rb = followTarget.GetComponent<Rigidbody>();
        float speed = rb != null ? rb.linearVelocity.magnitude : 0f;
        
        if (thirdPersonFollow != null) {
            float damping = Mathf.Lerp(baseDamping, depthDampingMultiplier, Mathf.Clamp01(depth / 40f));
            // В Cinemachine 3.x свойство BodyDamping управляет плавностью следования
            thirdPersonFollow.BodyDamping = new Vector3(damping, damping, damping);
        }
        
        float targetFOV = baseFOV + speed * speedFOVBoost;
        vcam.Lens.FieldOfView = Mathf.Lerp(vcam.Lens.FieldOfView, targetFOV, Time.deltaTime * 3f);
    }
}
