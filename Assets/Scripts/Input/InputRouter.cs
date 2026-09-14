using UnityEngine;

/// <summary>
/// Роутер ввода на новом Input System (polling — надёжно на всех платформах).
/// WASD/стрелки — движение, Q/E — нырок/всплытие, Shift — ускорение,
/// Space — уворот, F — лай, Esc/P — пауза.
/// Геймпад: стик, триггеры, A — уворот, X — лай.
/// </summary>
public class InputRouter : MonoBehaviour
{
    public static InputRouter Instance { get; private set; }

    public Vector2 MoveInput { get; private set; }
    public float DiveInput { get; private set; }
    public bool BoostHeld { get; private set; }
    public bool PausePressed { get; private set; }

    private bool _dodgeQueued;
    private bool _barkQueued;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
    }

    private void OnDestroy() { if (Instance == this) Instance = null; }

    private void Update()
    {
        PausePressed = false;
        Vector2 mv = Vector2.zero;
        float dv = 0f;
        bool boost = false;

        var kb = UnityEngine.InputSystem.Keyboard.current;
        if (kb != null)
        {
            if (kb.wKey.isPressed || kb.upArrowKey.isPressed) mv.y += 1f;
            if (kb.sKey.isPressed || kb.downArrowKey.isPressed) mv.y -= 1f;
            if (kb.aKey.isPressed || kb.leftArrowKey.isPressed) mv.x -= 1f;
            if (kb.dKey.isPressed || kb.rightArrowKey.isPressed) mv.x += 1f;
            if (kb.qKey.isPressed) dv -= 1f;
            if (kb.eKey.isPressed) dv += 1f;
            if (kb.leftShiftKey.isPressed || kb.rightShiftKey.isPressed) boost = true;
            if (kb.spaceKey.wasPressedThisFrame) _dodgeQueued = true;
            if (kb.fKey.wasPressedThisFrame) _barkQueued = true;
            if (kb.escapeKey.wasPressedThisFrame || kb.pKey.wasPressedThisFrame) PausePressed = true;
        }

        var gp = UnityEngine.InputSystem.Gamepad.current;
        if (gp != null)
        {
            var stick = gp.leftStick.ReadValue();
            if (stick.magnitude > 0.15f)
                mv = Vector2.Lerp(mv, stick, 0.8f);
            dv += gp.rightTrigger.ReadValue() - gp.leftTrigger.ReadValue();
            if (gp.rightShoulder.isPressed) boost = true;
            if (gp.buttonSouth.wasPressedThisFrame) _dodgeQueued = true;
            if (gp.buttonWest.wasPressedThisFrame) _barkQueued = true;
            if (gp.startButton.wasPressedThisFrame) PausePressed = true;
        }

        MoveInput = Vector2.ClampMagnitude(mv, 1f);
        DiveInput = Mathf.Clamp(dv, -1f, 1f);
        BoostHeld = boost;
    }

    public bool ConsumeDodge()
    {
        if (!_dodgeQueued) return false;
        _dodgeQueued = false;
        return true;
    }

    public bool ConsumeBark()
    {
        if (!_barkQueued) return false;
        _barkQueued = false;
        return true;
    }

    public Vector3 MoveVector => new Vector3(MoveInput.x, 0f, MoveInput.y);
}
