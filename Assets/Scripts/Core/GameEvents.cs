using System;
using UnityEngine;

/// <summary>
/// Статическая шина событий игры. Слои не знают друг о друге — только события.
/// </summary>
public static class GameEvents
{
    public static event Action<SealStats.Vitals> OnVitalsChanged;
    public static event Action<int> OnStageChanged;          // 1..4
    public static event Action<WeatherSystem.State> OnWeatherStateChanged;
    public static event Action<float> OnThreatLevel;          // 0..1 близость касатки
    public static event Action<float> OnOxygenCritical;
    public static event Action<string> OnDeath;               // причина (ключ локализации)
    public static event Action<int, GeneSet> OnGenerationStarted; // номер поколения, гены
    public static event Action<float> OnGrowthChanged;        // 0..1 прогресс стадии
    public static event Action OnBarked;
    public static event Action OnAte;

    public static void RaiseVitals(SealStats.Vitals v) => OnVitalsChanged?.Invoke(v);
    public static void RaiseStage(int stage) => OnStageChanged?.Invoke(stage);
    public static void RaiseWeather(WeatherSystem.State s) => OnWeatherStateChanged?.Invoke(s);
    public static void RaiseThreat(float t) => OnThreatLevel?.Invoke(t);
    public static void RaiseOxygenCritical(float ratio) => OnOxygenCritical?.Invoke(ratio);
    public static void RaiseDeath(string locKey) => OnDeath?.Invoke(locKey);
    public static void RaiseGenerationStarted(int gen, GeneSet genes) => OnGenerationStarted?.Invoke(gen, genes);
    public static void RaiseGrowth(float progress) => OnGrowthChanged?.Invoke(progress);
    public static void RaiseBarked() => OnBarked?.Invoke();
    public static void RaiseAte() => OnAte?.Invoke();

    /// <summary>Безопасная подписка — гасит исключения уже уничтоженных слушателей.</summary>
    public static void ClearAllDead()
    {
        OnVitalsChanged = null; OnStageChanged = null; OnWeatherStateChanged = null;
        OnThreatLevel = null; OnOxygenCritical = null; OnDeath = null;
        OnGenerationStarted = null; OnGrowthChanged = null; OnBarked = null; OnAte = null;
    }
}
