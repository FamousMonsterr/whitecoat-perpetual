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
    private CinemachineFollow follow;

    void Awake() {
        vcam = GetComponent<CinemachineCamera>();
        
        if (followTarget != null) {
            vcam.Follow = followTarget;
            vcam.LookAt = followTarget;
        }
        
        follow = vcam.GetComponent<CinemachineFollow>();
        if (follow != null) {
            follow.FollowOffset = new Vector3(0, 2.5f, -6f);
            follow.Damping = new Vector3(baseDamping, baseDamping, baseDamping);
        }
    }

    void Update() {
        if (vcam == null || followTarget == null) return;
        
        float depth = Mathf.Max(0, -followTarget.position.y);
        Rigidbody rb = followTarget.GetComponent<Rigidbody>();
        float speed = rb != null ? rb.linearVelocity.magnitude : 0f;
        
        if (follow != null) {
            float damping = Mathf.Lerp(baseDamping, depthDampingMultiplier, Mathf.Clamp01(depth / 40f));
            follow.Damping = new Vector3(damping, damping, damping);
        }
        
        float targetFOV = baseFOV + speed * speedFOVBoost;
        vcam.Lens.FieldOfView = Mathf.Lerp(vcam.Lens.FieldOfView, targetFOV, Time.deltaTime * 3f);
    }
}
