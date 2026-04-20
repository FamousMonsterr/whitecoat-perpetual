using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

public class InputHandler : MonoBehaviour
{
    public static InputHandler Instance { get; private set; }
    
    [Header("Gyro Settings")]
    public bool useGyro = true;
    public float gyroSensitivity = 1.5f;
    public float gyroDeadzone = 0.05f;
    
    [Header("Gamepad")]
    public float gamepadStickDeadzone = 0.15f;
    
    private Vector2 moveInput;
    private float diveInput;
    private bool dodgePressed;
    private UnityEngine.Gyroscope gyro;
    private bool gyroAvailable;

    public Vector2 MoveInput => moveInput;
    public float DiveInput => diveInput;
    public bool DodgePressed => dodgePressed;

    void Awake() {
        Instance = this;
        EnhancedTouchSupport.Enable();
        
        if (useGyro && SystemInfo.supportsGyroscope) {
            gyro = Input.gyro;
            gyro.enabled = true;
            gyroAvailable = true;
            Debug.Log("[Input] Gyro enabled");
        }
    }

    void Update() {
        dodgePressed = false;
        
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        diveInput = (Input.GetKey(KeyCode.Q) ? -1f : 0f) + (Input.GetKey(KeyCode.E) ? 1f : 0f);
        if (Input.GetKeyDown(KeyCode.Space)) dodgePressed = true;
        
        var gamepad = Gamepad.current;
        if (gamepad != null) {
            var stick = gamepad.leftStick.ReadValue();
            if (stick.magnitude > gamepadStickDeadzone)
                moveInput = Vector2.Lerp(moveInput, stick, 0.7f);
            
            diveInput += gamepad.rightTrigger.ReadValue() - gamepad.leftTrigger.ReadValue();
            if (gamepad.buttonSouth.wasPressedThisFrame) dodgePressed = true;
        }
        
        if (gyroAvailable) {
            var rot = gyro.rotationRateUnbiased;
            float gyroX = -rot.y * gyroSensitivity * Time.deltaTime;
            float gyroY = rot.x * gyroSensitivity * Time.deltaTime;
            
            if (Mathf.Abs(gyroX) > gyroDeadzone || Mathf.Abs(gyroY) > gyroDeadzone) {
                moveInput = Vector2.Lerp(moveInput, new Vector2(gyroX, gyroY), 0.4f);
            }
        }
        
        if (Application.isMobilePlatform) {
            foreach (var t in Touch.activeTouches) {
                if (t.phase == UnityEngine.InputSystem.TouchPhase.Began) dodgePressed = true;
            }
        }
        
        moveInput = Vector2.ClampMagnitude(moveInput, 1f);
        diveInput = Mathf.Clamp(diveInput, -1f, 1f);
    }
}
