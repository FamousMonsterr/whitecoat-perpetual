using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

/// <summary>
/// Визуал погоды: частицы снега/шторма, поствклиматические виньетки.
/// Все ссылки назначаются SceneBuilder — нулевых ссылок быть не может.
/// </summary>
[RequireComponent(typeof(Volume))]
public class WeatherVisuals : MonoBehaviour
{
    public ParticleSystem snowPS;    // пурга/снег
    public ParticleSystem rainPS;    // штормовые брызги
    public ParticleSystem windPS;    // позёмка у поверхности льда

    private WeatherSystem _weather;
    private Volume _volume;
    private Vignette _vignette;
    private ColorAdjustments _color;
    private ParticleSystem.EmissionModule _snowEmission;
    private ParticleSystem.EmissionModule _windEmission;
    private float _vignetteCurrent = 0.18f;

    private void Start()
    {
        _weather = WeatherSystem.Instance;
        if (_weather == null) _weather = FindFirstObjectByType<WeatherSystem>();
        _volume = GetComponent<Volume>();

        if (_volume.profile == null)
        {
            _volume.profile = ScriptableObject.CreateInstance<VolumeProfile>();
        }
        _volume.profile.TryGet(out _vignette);
        _volume.profile.TryGet(out _color);
        if (_vignette == null)
        {
            _vignette = _volume.profile.Add<Vignette>();
            _vignette.intensity.Override(0.18f);
        }
        if (_color == null)
        {
            _color = _volume.profile.Add<ColorAdjustments>();
        }

        if (snowPS != null) _snowEmission = snowPS.emission;
        if (windPS != null) _windEmission = windPS.emission;

        GameEvents.OnWeatherStateChanged += HandleWeather;
        HandleWeather(_weather != null ? _weather.Current : WeatherSystem.State.Clear);
    }

    private void OnDestroy()
    {
        GameEvents.OnWeatherStateChanged -= HandleWeather;
    }

    private void HandleWeather(WeatherSystem.State state)
    {
        if (rainPS != null)
        {
            if (state == WeatherSystem.State.Storm) rainPS.Play();
            else rainPS.Stop();
        }
        if (snowPS != null && state != WeatherSystem.State.Blizzard) snowPS.Stop();
        if (snowPS != null && state == WeatherSystem.State.Blizzard) snowPS.Play();
        if (windPS != null && state == WeatherSystem.State.Clear) windPS.Stop();
    }

    private void Update()
    {
        if (_weather == null) return;

        // Осадки — плавная плотность
        if (snowPS != null && snowPS.isPlaying)
            _snowEmission.rateOverTime = 220f * _weather.SnowRate;
        if (windPS != null)
        {
            if (_weather.SnowRate > 0.05f && !windPS.isPlaying && _weather.WindForce > 5f) windPS.Play();
            if (windPS.isPlaying) _windEmission.rateOverTime = 120f * _weather.WindForce / 12f;
        }

        // Виньетка + цветокор по погоде и угрозе
        float weatherVignette = Mathf.Lerp(0.18f, 0.5f, 1f - _weather.Visibility01);
        _vignetteCurrent = Mathf.Lerp(_vignetteCurrent, weatherVignette, Time.deltaTime * 2f);
        if (_vignette != null) _vignette.intensity.Override(_vignetteCurrent);
        if (_color != null)
        {
            float cold = Mathf.InverseLerp(0f, -15f, _weather.Temperature);
            _color.colorFilter.Override(Color.Lerp(Color.white, new Color(0.82f, 0.88f, 1.05f), cold));
            _color.saturation.Override(Mathf.Lerp(6f, -18f, cold));
        }
    }

    /// <summary>Пульс виньетки при угрозе (вызывает HUD через событие угрозы).</summary>
    public void AddThreatPulse(float amount)
    {
        _vignetteCurrent = Mathf.Min(0.75f, _vignetteCurrent + amount);
    }
}
