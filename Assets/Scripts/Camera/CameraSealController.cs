using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CameraSealController : MonoBehaviour
{
    public Transform followTarget;
    public float baseDamping = 0.8f;
    public float depthDampingMultiplier = 0.3f;
    public float speedFOVBoost = 8f;
    public float baseFOV = 45f;

    private CinemachineVirtualCamera vcam;

    void Awake() {
        vcam = GetComponent<CinemachineVirtualCamera>();
        
        if (followTarget != null) {
            vcam.Follow = followTarget;
            vcam.LookAt = followTarget;
        }
        
        var transposer = vcam.GetCinemachineComponent<CinemachineTransposer>();
        if (transposer != null) {
            transposer.m_FollowOffset = new Vector3(0, 2.5f, -6f);
            transposer.m_XDamping = baseDamping;
            transposer.m_YDamping = baseDamping;
            transposer.m_ZDamping = baseDamping;
            transposer.m_BindingMode = CinemachineTransposer.BindingMode.SimpleFollowWithWorldUp;
        }
    }

    void Update() {
        if (vcam == null || followTarget == null) return;
        
        float depth = Mathf.Max(0, -followTarget.position.y);
        Rigidbody rb = followTarget.GetComponent<Rigidbody>();
        float speed = rb != null ? rb.velocity.magnitude : 0f;
        
        var transposer = vcam.GetCinemachineComponent<CinemachineTransposer>();
        if (transposer != null) {
            transposer.m_XDamping = Mathf.Lerp(baseDamping, depthDampingMultiplier, Mathf.Clamp01(depth / 40f));
            transposer.m_YDamping = transposer.m_XDamping;
            transposer.m_ZDamping = transposer.m_XDamping;
        }
        
        float targetFOV = baseFOV + speed * speedFOVBoost;
        vcam.m_Lens.FieldOfView = Mathf.Lerp(vcam.m_Lens.FieldOfView, targetFOV, Time.deltaTime * 3f);
    }
}
