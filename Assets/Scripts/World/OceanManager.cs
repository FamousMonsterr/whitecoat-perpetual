using UnityEngine;

/// <summary>
/// Океан: уровень воды с волнами (CPU-функция та же, что в шейдере воды),
/// определение «под водой», запросы плавучести для физики.
/// </summary>
public class OceanManager : MonoBehaviour
{
    public static OceanManager Instance { get; private set; }

    [Header("Форма волн (дублируется в шейдере OceanWater)")]
    public float waveAmpBase = 0.22f;
    public float waveLengthA = 9.5f;
    public float waveLengthB = 5.1f;
    public float waveLengthC = 2.7f;
    public float waveSpeed = 1.35f;

    private WeatherSystem _weather;

    private void Awake() { Instance = this; }
    private void OnDestroy() { if (Instance == this) Instance = null; }

    private void Start() { _weather = FindFirstObjectByType<WeatherSystem>(); }

    /// <summary>Амплитуда волн зависит от погоды.</summary>
    public float WaveAmp => waveAmpBase * Mathf.Lerp(1f, 9f, _weather != null ? _weather.Intensity : 0f);

    /// <summary>Высота поверхности воды в мировой точке (XZ).</summary>
    public float WaterLevelAt(float x, float z, float time)
    {
        float k1 = 2f * Mathf.PI / waveLengthA, k2 = 2f * Mathf.PI / waveLengthB, k3 = 2f * Mathf.PI / waveLengthC;
        float w = waveSpeed;
        return GameConfig.WaterLevel
             + WaveAmp * (Mathf.Sin(x * k1 + time * w * 1.1f) * 0.6f
                        + Mathf.Sin((x * 0.4f + z * 0.9f) * k2 + time * w * 1.7f) * 0.3f
                        + Mathf.Sin((z * 1.1f - x * 0.2f) * k3 + time * w * 2.3f) * 0.15f);
    }

    public float WaterLevelAt(Vector3 pos, float time) => WaterLevelAt(pos.x, pos.z, time);

    public float WaterLevelNow(Vector3 pos) => WaterLevelAt(pos, Time.time);

    /// <summary>Погружена ли точка под воду.</summary>
    public bool IsUnderwater(Vector3 pos)
    {
        return pos.y < WaterLevelNow(pos);
    }

    /// <summary>Затопленность (0..1) тела с радиусом r в точке pos — для плавучести.</summary>
    public float Submersion(Vector3 pos, float radius)
    {
        float lvl = WaterLevelNow(pos);
        return Mathf.Clamp01((lvl - (pos.y - radius)) / (radius * 2f));
    }
}
