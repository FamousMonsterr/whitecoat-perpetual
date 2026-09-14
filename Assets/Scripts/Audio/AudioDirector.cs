using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Директор аудио: генеративно-синтезированные WAV-дорожки (Assets/Audio),
/// адаптивный микс по глубине/угрозе/погоде. Замена FMOD-моку.
/// </summary>
public class AudioDirector : MonoBehaviour
{
    public static AudioDirector Instance { get; private set; }

    [System.Serializable]
    public class SfxEntry
    {
        public string key;
        public AudioClip clip;
        public float volume = 1f;
        public float minDistance = 4f;
        public float maxDistance = 60f;
    }

    [Header("Музыка и амбиент (назначает SceneBuilder)")]
    public AudioSource musicSource;      // 2D loop
    public AudioSource ambientSource;    // 2D loop (океан/ветер)
    public AudioSource underwaterSource; // 2D loop (подводный гул)
    public List<SfxEntry> sfx = new List<SfxEntry>();

    private Dictionary<string, SfxEntry> _sfxMap;
    private SealController _seal;
    private WeatherSystem _weather;
    private DayNightCycle _day;
    private bool _underwater;
    private float _threatLevel;
    private float _oneShotTimer;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        _sfxMap = new Dictionary<string, SfxEntry>();
        foreach (var e in sfx)
            if (!string.IsNullOrEmpty(e.key) && e.clip != null)
                _sfxMap[e.key] = e;
    }

    private void OnDestroy()
    {
        if (Instance == this) Instance = null;
        OnDestroySub();
    }

    private void Start()
    {
        _seal = SealController.Instance;
        _weather = WeatherSystem.Instance;
        if (_weather == null) _weather = FindFirstObjectByType<WeatherSystem>();
        _day = FindFirstObjectByType<DayNightCycle>();

        if (musicSource != null) { musicSource.loop = true; musicSource.Play(); }
        if (ambientSource != null) { ambientSource.loop = true; ambientSource.Play(); }
        if (underwaterSource != null)
        {
            underwaterSource.loop = true;
            underwaterSource.volume = 0f;
            underwaterSource.Play();
        }
        GameEvents.OnThreatLevel += HandleThreat;
        GameEvents.OnOxygenCritical += HandleOxygen;
        GameEvents.OnStageChanged += HandleStage;
    }

    private void HandleThreat(float t) => _threatLevel = t;
    private void HandleOxygen(float _) => PlaySfx("breath");
    private void HandleStage(int _) => PlaySfx("evolve");

    private void OnDestroySub()
    {
        GameEvents.OnThreatLevel -= HandleThreat;
        GameEvents.OnOxygenCritical -= HandleOxygen;
        GameEvents.OnStageChanged -= HandleStage;
    }

    private void Update()
    {
        if (_seal == null) _seal = SealController.Instance;
        if (_weather == null) _weather = WeatherSystem.Instance;
        _oneShotTimer -= Time.deltaTime;

        // Адаптивный микс
        if (ambientSource != null && _weather != null)
        {
            float storm = Mathf.Clamp01(_weather.WindForce / 12f);
            ambientSource.volume = Mathf.Lerp(0.55f, 0.75f, storm) * (1f - (_underwater ? 0.7f : 0f));
        }
        if (underwaterSource != null)
        {
            float depthFactor = 0.4f;
            if (_seal != null) depthFactor = Mathf.Clamp01(_seal.Depth / 25f);
            float target = _underwater ? Mathf.Lerp(0.35f, 0.7f, depthFactor) : 0f;
            underwaterSource.volume = Mathf.Lerp(underwaterSource.volume, target, Time.deltaTime * 2.5f);
        }
        if (musicSource != null && _day != null)
        {
            // Ночь — тише и глубже
            musicSource.volume = Mathf.Lerp(GameConfig.MusicVolume, GameConfig.MusicVolume * 0.55f, _day.NightFactor);
        }
        // Сердцебиение при угрозе
        if (_threatLevel > 0.6f && _oneShotTimer <= 0f)
        {
            PlaySfx("heartbeat");
            _oneShotTimer = Mathf.Lerp(1.4f, 0.55f, (_threatLevel - 0.6f) / 0.4f);
        }
    }

    public static void SetUnderwater(bool under) => Instance?._setUnderwater(under);
    private void _setUnderwater(bool under) => _underwater = under;

    /// <summary>3D-звук в точке мира (создаёт временный источник).</summary>
    public static void PlaySfx(string key, Vector3 pos)
    {
        if (Instance == null || Instance._sfxMap == null || !Instance._sfxMap.TryGetValue(key, out var entry))
            return;
        var go = new GameObject("sfx_" + key);
        go.transform.position = pos;
        var src = go.AddComponent<AudioSource>();
        src.clip = entry.clip;
        src.volume = entry.volume * GameConfig.SfxVolume;
        src.spatialBlend = 1f;
        src.minDistance = entry.minDistance;
        src.maxDistance = entry.maxDistance;
        src.rolloffMode = AudioRolloffMode.Linear;
        src.dopplerLevel = 0.5f;
        src.Play();
        Destroy(go, entry.clip.length + 0.1f);
    }

    public static void PlaySfx(string key)
    {
        if (Instance == null || Instance._sfxMap == null || !Instance._sfxMap.TryGetValue(key, out var entry))
            return;
        Instance.StartCoroutine(Instance.Play2DCo(entry));
    }

    private System.Collections.IEnumerator Play2DCo(SfxEntry entry)
    {
        var go = new GameObject("sfx2d_" + entry.key);
        var src = go.AddComponent<AudioSource>();
        src.clip = entry.clip;
        src.volume = entry.volume * GameConfig.SfxVolume * 0.8f;
        src.spatialBlend = 0f;
        src.Play();
        yield return new WaitForSeconds(entry.clip.length + 0.1f);
        Destroy(go);
    }
}
