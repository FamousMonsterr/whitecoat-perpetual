using System;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Погода Арктики: марковская цепь состояний с весами, плавная интерполяция
/// параметров, детерминированность в пределах забега (по сиду моря).
/// Состояния: Ясно, Пасмурно, Шторм, Пурга.
/// </summary>
public class WeatherSystem : MonoBehaviour
{
    public enum State { Clear, Overcast, Storm, Blizzard }

    [Serializable]
    public class WeatherParams
    {
        public float visibility01;  // 0..1
        public float waveFactor;    // 0..1 к амплитуде волн
        public float windForce;     // 0..12
        public float snowRate;      // 0..1 плотность осадков
        public float fogDensity;    // подводный туман базовый
        public float temperature;   // цельсий, для HUD
    }

    public static WeatherSystem Instance { get; private set; }

    public State Current { get; private set; } = State.Clear;
    public State Previous { get; private set; } = State.Clear;

    public float Visibility01 { get; private set; } = 1f;
    public float WaveFactor { get; private set; } = 0.1f;
    public float WindForce { get; private set; }
    public float SnowRate { get; private set; }
    public float FogDensity { get; private set; }
    public float Temperature { get; private set; } = -4f;
    public float Intensity { get; private set; } // 0 ясно .. 1 пурга

    public UnityEvent<State> OnStateChanged;

    private WeatherParams _from = ParamsOf(State.Clear);
    private WeatherParams _to = ParamsOf(State.Clear);
    private float _transitionT = 1f;
    private float _stateTimer = 60f;

    private static WeatherParams ParamsOf(State s)
    {
        switch (s)
        {
            case State.Overcast: return new WeatherParams { visibility01 = 0.75f, waveFactor = 0.25f, windForce = 3.5f, snowRate = 0.15f, fogDensity = 0.012f, temperature = -6f };
            case State.Storm: return new WeatherParams { visibility01 = 0.42f, waveFactor = 0.62f, windForce = 8f, snowRate = 0.55f, fogDensity = 0.02f, temperature = -9f };
            case State.Blizzard: return new WeatherParams { visibility01 = 0.14f, waveFactor = 0.85f, windForce = 12f, snowRate = 1f, fogDensity = 0.034f, temperature = -15f };
            default: return new WeatherParams { visibility01 = 1f, waveFactor = 0.08f, windForce = 0.5f, snowRate = 0f, fogDensity = 0.006f, temperature = -3f };
        }
    }

    private static readonly (State next, float w)[][] TransitionTable =
    {
        // Clear ->
        new[] { (State.Clear, 0.50f), (State.Overcast, 0.38f), (State.Storm, 0.12f), (State.Blizzard, 0.0f) },
        // Overcast ->
        new[] { (State.Clear, 0.35f), (State.Overcast, 0.30f), (State.Storm, 0.26f), (State.Blizzard, 0.09f) },
        // Storm ->
        new[] { (State.Clear, 0.10f), (State.Overcast, 0.40f), (State.Storm, 0.32f), (State.Blizzard, 0.18f) },
        // Blizzard ->
        new[] { (State.Clear, 0.04f), (State.Overcast, 0.48f), (State.Storm, 0.30f), (State.Blizzard, 0.18f) },
    };

    private void Awake()
    {
        Instance = this;
        var rng = new System.Random(SeaRandom.Seed() + 17);
        Current = (State)rng.Next(0, 2); // старт без пурги
        _to = ParamsOf(Current);
        _from = _to;
        ApplyInstant();
    }

    private void OnDestroy() { if (Instance == this) Instance = null; }

    private void Start()
    {
        GameEvents.RaiseWeather(Current);
        OnStateChanged?.Invoke(Current);
    }

    private void Update()
    {
        _stateTimer -= Time.deltaTime;

        if (_transitionT < 1f)
        {
            _transitionT = Mathf.Min(1f, _transitionT + Time.deltaTime / GameConfig.WeatherTransitionSec);
            float smooth = Mathf.SmoothStep(0f, 1f, _transitionT);
            Visibility01 = Mathf.Lerp(_from.visibility01, _to.visibility01, smooth);
            WaveFactor = Mathf.Lerp(_from.waveFactor, _to.waveFactor, smooth);
            WindForce = Mathf.Lerp(_from.windForce, _to.windForce, smooth);
            SnowRate = Mathf.Lerp(_from.snowRate, _to.snowRate, smooth);
            FogDensity = Mathf.Lerp(_from.fogDensity, _to.fogDensity, smooth);
            Temperature = Mathf.Lerp(_from.temperature, _to.temperature, smooth);
        }

        Intensity = Mathf.Clamp01(
            (Current == State.Blizzard ? 1f : Current == State.Storm ? 0.65f : Current == State.Overcast ? 0.3f : 0f) *
            (0.6f + 0.4f * _transitionT));

        if (_stateTimer <= 0f)
        {
            PickNextState();
        }
    }

    private void PickNextState()
    {
        var rng = new System.Random(SeaRandom.Seed() + (int)(Time.time * 1000) % 99991);
        var row = TransitionTable[(int)Current];
        float roll = (float)rng.NextDouble();
        float acc = 0f;
        State next = row[row.Length - 1].next;
        foreach (var (nextState, w) in row)
        {
            acc += w;
            if (roll <= acc) { next = nextState; break; }
        }
        if (next == Current)
        {
            _stateTimer = UnityEngine.Random.Range(GameConfig.WeatherMinDuration, GameConfig.WeatherMaxDuration);
            return;
        }
        SetState(next);
    }

    public void SetState(State s)
    {
        if (s == Current) return;
        Previous = Current;
        Current = s;
        _from = ParamsOf(Previous);
        _to = ParamsOf(Current);
        _transitionT = 0f;
        _stateTimer = UnityEngine.Random.Range(GameConfig.WeatherMinDuration, GameConfig.WeatherMaxDuration);
        GameEvents.RaiseWeather(Current);
        OnStateChanged?.Invoke(Current);
    }

    private void ApplyInstant()
    {
        Visibility01 = _to.visibility01;
        WaveFactor = _to.waveFactor;
        WindForce = _to.windForce;
        SnowRate = _to.snowRate;
        FogDensity = _to.fogDensity;
        Temperature = _to.temperature;
        _transitionT = 1f;
    }

    public string StateLocKey => Current switch
    {
        State.Clear => "weather_clear",
        State.Overcast => "weather_overcast",
        State.Storm => "weather_storm",
        State.Blizzard => "weather_blizzard",
        _ => "weather_clear"
    };
}
