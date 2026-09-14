using UnityEngine;

/// <summary>
/// Цикл дня и ночи: солнце, луна, цвет неба/тумана, интенсивность биолюминесценции.
/// </summary>
public class DayNightCycle : MonoBehaviour
{
    public static DayNightCycle Instance { get; private set; }

    [Header("Ссылки (назначаются SceneBuilder)")]
    public Light sun;
    public Light moon;
    public Transform sunPivot;

    [Header("Цвета")]
    public Gradient skyTop;
    public Gradient skyBottom;
    public Gradient sunColor;
    public AnimationCurve sunIntensity = AnimationCurve.Linear(0f, 0f, 1f, 1.15f);

    [Range(0f, 1f)] public float startDayTime = 0.32f; // старт утром
    public float DayTime { get; private set; }
    public bool IsNight => DayTime < 0.18f || DayTime > 0.82f;
    public float NightFactor { get; private set; } // 0 день, 1 ночь

    private Camera _cam;
    private static readonly int TopColor = Shader.PropertyToID("_TopColor");
    private static readonly int BottomColor = Shader.PropertyToID("_BottomColor");

    private void Awake()
    {
        Instance = this;
        DayTime = startDayTime;
        _cam = Camera.main;
    }

    private void OnDestroy() { if (Instance == this) Instance = null; }

    private void Update()
    {
        if (GameManager.Instance == null || GameManager.Instance.State == GameManager.GameState.MainMenu)
            DayTime += Time.deltaTime / GameConfig.DayLengthSec * 0.25f;
        else
            DayTime += Time.deltaTime / GameConfig.DayLengthSec;
        if (DayTime >= 1f) DayTime -= 1f;

        // Солнце по дуге: 0.25=полдень, 0.75=полночь
        float sunAngle = (DayTime - 0.25f) * 2f * Mathf.PI;
        if (sunPivot != null)
            sunPivot.rotation = Quaternion.Euler(0f, 0f, 0f) *
                                Quaternion.AngleAxis(Mathf.Rad2Deg * sunAngle, Vector3.right);
        else if (sun != null)
            sun.transform.rotation = Quaternion.Euler(Mathf.Rad2Deg * sunAngle, 35f, 0f);

        // Ночной фактор: плавная колоколообразная кривая
        float daylight = Mathf.Clamp01(Mathf.Cos((DayTime - 0.25f) * 2f * Mathf.PI) * 0.5f + 0.5f);
        NightFactor = 1f - Mathf.SmoothStep(0.05f, 0.35f, daylight);

        if (sun != null)
        {
            float t = Mathf.Clamp01(Mathf.Cos((DayTime - 0.25f) * 2f * Mathf.PI) * 0.5f + 0.5f);
            sun.intensity = sunIntensity.Evaluate(t) * (1f - NightFactor * 0.9f);
            if (sunColor != null && sun.color != sunColor.Evaluate(t))
                sun.color = sunColor.Evaluate(t);
            sun.shadows = NightFactor > 0.85f ? LightShadows.None : LightShadows.Soft;
        }
        if (moon != null)
        {
            moon.intensity = NightFactor * 0.35f;
        }

        // Небо (градиентный skybox-шейдер)
        if (_cam == null) _cam = Camera.main;
        if (_cam != null && RenderSettings.skybox != null && RenderSettings.skybox.HasProperty(TopColor))
        {
            var mat = RenderSettings.skybox;
            mat.SetColor(TopColor, skyTop != null ? skyTop.Evaluate(DayTime) : Color.cyan);
            mat.SetColor(BottomColor, skyBottom != null ? skyBottom.Evaluate(DayTime) : Color.white);
        }

        // Амбиент
        RenderSettings.ambientLight = Color.Lerp(
            new Color(0.10f, 0.13f, 0.18f),
            new Color(0.55f, 0.60f, 0.66f),
            1f - NightFactor);
    }
}
