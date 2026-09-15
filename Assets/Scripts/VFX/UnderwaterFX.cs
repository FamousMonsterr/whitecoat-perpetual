using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

/// <summary>
/// Подводная атмосфера: туман, цвет, виньетка по глубине; над водой — арктический воздух.
/// Управляет RenderSettings.fog и глобальным Volume.
/// </summary>
public class UnderwaterFX : MonoBehaviour
{
    private Camera _cam;
    private OceanManager _ocean;
    private WeatherSystem _weather;
    private DayNightCycle _day;
    private Volume _volume;
    private ColorAdjustments _colorAdj;
    private bool _wasUnderwater;

    [Header("Цвета воды по глубине")]
    public Color shallowColor = new Color(0.12f, 0.42f, 0.55f);
    public Color deepColor = new Color(0.015f, 0.10f, 0.18f);
    public float maxFogDensity = 0.052f;

    private void Start()
    {
        _cam = Camera.main;
        _ocean = OceanManager.Instance;
        _weather = FindAnyObjectByType<WeatherSystem>();
        _day = FindAnyObjectByType<DayNightCycle>();
        _volume = FindAnyObjectByType<Volume>();
        if (_volume != null)
        {
            if (_volume.profile == null)
                _volume.profile = ScriptableObject.CreateInstance<VolumeProfile>();
            _volume.profile.TryGet(out _colorAdj);
        }
    }

    private void Update()
    {
        if (_cam == null) _cam = Camera.main;
        if (_ocean == null || _cam == null) return;

        bool under = _ocean.IsUnderwater(_cam.transform.position);
        if (under != _wasUnderwater)
        {
            _wasUnderwater = under;
            AudioDirector.SetUnderwater(under);
        }

        if (under)
        {
            float depth = Mathf.Max(0f, _ocean.WaterLevelNow(_cam.transform.position) - _cam.transform.position.y);
            float t = Mathf.Clamp01(depth / 30f);
            Color c = Color.Lerp(shallowColor, deepColor, t);
            // ночь темнее
            if (_day != null) c *= Mathf.Lerp(1f, 0.28f, _day.NightFactor);
            // пурга у поверхности мутнее
            if (_weather != null) c = Color.Lerp(c, new Color(0.20f, 0.30f, 0.36f), _weather.SnowRate * 0.3f * (1f - t));

            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.Exponential;
            RenderSettings.fogColor = c;
            RenderSettings.fogDensity = Mathf.Lerp(0.020f, maxFogDensity, t) *
                                        (_weather != null ? Mathf.Lerp(1f, 1.5f, _weather.SnowRate) : 1f);
            if (_colorAdj != null)
            {
                _colorAdj.colorFilter.Override(Color.Lerp(new Color(0.85f, 1.0f, 1.08f), new Color(0.7f, 0.92f, 1.1f), t));
                _colorAdj.saturation.Override(Mathf.Lerp(4f, -26f, t));
            }
        }
        else
        {
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.Linear;
            Color air = new Color(0.72f, 0.80f, 0.88f);
            if (_day != null) air *= Mathf.Lerp(1f, 0.22f, _day.NightFactor);
            if (_weather != null)
            {
                air = Color.Lerp(air, new Color(0.78f, 0.82f, 0.88f), _weather.SnowRate);
                RenderSettings.fogStartDistance = Mathf.Lerp(60f, 4f, 1f - _weather.Visibility01);
                RenderSettings.fogEndDistance = Mathf.Lerp(400f, 60f, 1f - _weather.Visibility01);
            }
            else { RenderSettings.fogStartDistance = 60f; RenderSettings.fogEndDistance = 400f; }
            RenderSettings.fogColor = air;
            if (_colorAdj != null)
            {
                _colorAdj.colorFilter.Override(Color.white);
                _colorAdj.saturation.Override(6f);
            }
        }
    }
}
