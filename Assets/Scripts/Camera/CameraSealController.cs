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

    void Awake() {
        vcam = GetComponent<CinemachineCamera>();
        
        if (followTarget != null) {
            vcam.Follow = followTarget;
            vcam.LookAt = followTarget;
        }
        
        var transposer = vcam.GetCinemachineComponent<CinemachineTransposer>();
        if (transposer != null) {
            transposer.FollowOffset = new Vector3(0, 2.5f, -6f);
            transposer.XDamping = baseDamping;
            transposer.YDamping = baseDamping;
            transposer.ZDamping = baseDamping;
            transposer.BindingMode = CinemachineTransposer.BindingModes.SimpleFollowWithWorldUp;
        }
    }

    void Update() {
        if (vcam == null || followTarget == null) return;
        
        float depth = Mathf.Max(0, -followTarget.position.y);
        Rigidbody rb = followTarget.GetComponent<Rigidbody>();
        float speed = rb != null ? rb.velocity.magnitude : 0f;
        
        var transposer = vcam.GetCinemachineComponent<CinemachineTransposer>();
        if (transposer != null) {
            float damping = Mathf.Lerp(baseDamping, depthDampingMultiplier, Mathf.Clamp01(depth / 40f));
            transposer.XDamping = damping;
            transposer.YDamping = damping;
            transposer.ZDamping = damping;
        }
        
        float targetFOV = baseFOV + speed * speedFOVBoost;
        vcam.Lens.FieldOfView = Mathf.Lerp(vcam.Lens.FieldOfView, targetFOV, Time.deltaTime * 3f);
    }
}
