using System;
using UnityEngine;

/// <summary>
/// Генетика поколений: живёт между сценами и запусками (DontDestroyOnLoad).
/// Хранит гены «линии крови»: при смерти гены белька становятся родительскими,
/// новое поколение рождается чуть сильнее — ядро цикла игры.
/// </summary>
public class GeneticsManager : MonoBehaviour
{
    public static GeneticsManager Instance { get; private set; }

    public int Generation { get; private set; } = 1;
    public GeneSet Lineage { get; private set; } = GeneSet.Starter();
    public GeneSet Current { get; private set; }
    public float LifetimeFood { get; private set; }
    public float BestDepth { get; private set; }
    public int TotalDescendants { get; private set; }

    private System.Random _rng;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        _rng = new System.Random(SeaRandom.Seed());
        Load();
        Current = Lineage.Clone();
        Current.Mutate(_rng, 0.05f);
    }

    /// <summary>Начать новое поколение после смерти текущего белька.</summary>
    public GeneSet BeginNextGeneration(float lifeFood, float lifeBestDepth)
    {
        LifetimeFood += lifeFood;
        BestDepth = Mathf.Max(BestDepth, lifeBestDepth);
        TotalDescendants++;
        Generation++;
        // Наследование: линия + вклад прожитой жизни (прожил дольше-сытее — сильнее дети)
        var contribution = Current.Clone();
        float maturity = Mathf.Clamp01(lifeFood / 120f);
        contribution.Mutate(_rng, 0.06f + 0.10f * maturity);
        Lineage = GeneSet.Crossover(Lineage, contribution, _rng);
        Lineage.Mutate(_rng, 0.04f);
        Current = Lineage.Clone();
        Current.Mutate(_rng, 0.05f);
        Save();
        return Current;
    }

    public void RestartLineage()
    {
        Generation = 1;
        Lineage = GeneSet.Starter();
        LifetimeFood = 0; BestDepth = 0; TotalDescendants = 0;
        Current = Lineage.Clone();
        Save();
    }

    public void AddFood(float amount) => LifetimeFood += 0f; // учёт внутри забега

    // --- Сохранение ---
    [Serializable]
    private class GeneticsSave
    {
        public int generation;
        public GeneSet lineage;
        public float lifetimeFood;
        public float bestDepth;
        public int descendants;
    }

    public void Save()
    {
        var data = new GeneticsSave
        {
            generation = Generation,
            lineage = Lineage,
            lifetimeFood = LifetimeFood,
            bestDepth = BestDepth,
            descendants = TotalDescendants
        };
        SaveSystem.WriteFile("genetics.json", JsonUtility.ToJson(data));
    }

    private void Load()
    {
        var json = SaveSystem.ReadFile("genetics.json");
        if (string.IsNullOrEmpty(json)) return;
        try
        {
            var data = JsonUtility.FromJson<GeneticsSave>(json);
            if (data != null && data.lineage != null)
            {
                Generation = Mathf.Max(1, data.generation);
                Lineage = data.lineage;
                LifetimeFood = data.lifetimeFood;
                BestDepth = data.bestDepth;
                TotalDescendants = data.descendants;
            }
        }
        catch (Exception e) { Debug.LogWarning("[Genetics] save corrupted: " + e.Message); }
    }
}

/// <summary>Детерминированный сид сессии — мир одного забега воспроизводим.</summary>
public static class SeaRandom
{
    private static int _seed;
    private static bool _init;
    public static int Seed()
    {
        if (!_init)
        {
            _seed = PlayerPrefs.GetInt("sea_seed", 0);
            if (_seed == 0) { _seed = (int)(System.DateTime.UtcNow.Ticks % int.MaxValue); if (_seed < 0) _seed = -_seed; PlayerPrefs.SetInt("sea_seed", _seed); }
            _init = true;
        }
        return _seed;
    }
    public static void Reroll()
    {
        _seed = (int)(System.DateTime.UtcNow.Ticks % int.MaxValue);
        if (_seed < 0) _seed = -_seed;
        PlayerPrefs.SetInt("sea_seed", _seed);
        _init = true;
    }
}
