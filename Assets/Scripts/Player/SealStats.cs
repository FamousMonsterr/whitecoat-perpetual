using UnityEngine;

/// <summary>
/// Витальные показатели белька: здоровье, кислород, стамина, голод, тепло.
/// Логика дренажа/восстановления — здесь; SEAL-контроллер только двигает тело.
/// </summary>
public class SealStats : MonoBehaviour
{
    public struct Vitals
    {
        public float health, oxygen, stamina, hunger, warmth;
        public bool underwater, onIce, inBlizzard;
        public float depth, safeDepth;
        public int stage;
        public float growth01;
    }

    public static SealStats Instance { get; private set; }

    [Header("Текущие значения")]
    public float health = GameConfig.BaseHealth;
    public float oxygen = GameConfig.BaseOxygen;
    public float stamina = GameConfig.BaseStamina;
    public float hunger = GameConfig.BaseHunger;
    public float warmth = GameConfig.BaseWarmth;

    [Header("Состояние (заполняет SealController)")]
    public bool underwater;
    public bool onIce;
    public float depth;

    [Header("Рост")]
    public float growthXP;
    public int stage = 1;

    public GeneSet Genes { get; private set; }
    private SealController _seal;
    private WeatherSystem _weather;
    private OceanManager _ocean;
    private bool _dead;
    private float _oxygenWarnedAt = -99f;

    public float MaxOxygen => GameConfig.BaseOxygen * (Genes != null ? Genes.OxygenMult : 1f);
    public float GrowthToNext
    {
        get
        {
            switch (stage)
            {
                case 1: return GameConfig.Stage2XP;
                case 2: return GameConfig.Stage3XP;
                case 3: return GameConfig.Stage4XP;
                default: return 1f;
            }
        }
    }
    public float Growth01 => stage >= 4 ? 1f : growthXP / GrowthToNext;

    private void Awake()
    {
        Instance = this;
        _seal = GetComponent<SealController>();
    }

    private void OnDestroy() { if (Instance == this) Instance = null; }

    private void Start()
    {
        _weather = FindAnyObjectByType<WeatherSystem>();
        _ocean = OceanManager.Instance;
        ApplyGenes(GeneticsManager.Instance != null ? GeneticsManager.Instance.Current : GeneSet.Starter());
    }

    public void ApplyGenes(GeneSet genes)
    {
        Genes = genes;
        oxygen = MaxOxygen;
    }

    public void AddGrowth(float xp)
    {
        if (stage >= 4) return;
        growthXP += xp;
        while (stage < 4 && growthXP >= GrowthToNext)
        {
            growthXP -= GrowthToNext;
            stage++;
            GameEvents.RaiseStage(stage);
        }
        GameEvents.RaiseGrowth(Growth01);
    }

    public void Damage(float amount, string causeLocKey)
    {
        if (_dead) return;
        health -= amount;
        if (health <= 0f)
        {
            health = 0f;
            _dead = true;
            GameEvents.RaiseDeath(causeLocKey);
        }
    }

    private void Update()
    {
        if (_dead) return;
        float dt = Time.deltaTime;

        // --- Кислород ---
        bool canBreathe = !underwater || _seal != null && _seal.CanBreatheNow;
        if (canBreathe)
            oxygen = Mathf.Min(MaxOxygen, oxygen + GameConfig.OxygenRefillPerSec * dt);
        else
            oxygen -= GameConfig.OxygenDrainPerSec * dt;
        if (oxygen < 0f)
        {
            oxygen = 0f;
            Damage(GameConfig.DrownHealthDrain * dt, "death_drown");
        }
        float oxyRatio = oxygen / MaxOxygen;
        if (oxyRatio < 0.28f && Time.time - _oxygenWarnedAt > 1.4f)
        {
            _oxygenWarnedAt = Time.time;
            GameEvents.RaiseOxygenCritical(oxyRatio);
        }

        // --- Голод ---
        float hungerDrain = GameConfig.HungerDrainPerSec;
        if (_seal != null && _seal.IsSwimmingFast) hungerDrain *= GameConfig.HungerSwimMult;
        hunger -= hungerDrain * dt;
        if (hunger <= 0f)
        {
            hunger = 0f;
            Damage(GameConfig.StarvationHealthDrain * dt, "death_starve");
        }

        // --- Тепло ---
        float warmthRate;
        bool blizzard = _weather != null && _weather.Current == WeatherSystem.State.Blizzard;
        bool storm = _weather != null && _weather.Current == WeatherSystem.State.Storm;
        if (underwater && !onIce)
            warmthRate = -GameConfig.WarmthInWaterDrain * (Genes != null ? Genes.WarmthDrainMult : 1f);
        else if (blizzard)
            warmthRate = -GameConfig.WarmthBlizzardDrain * (Genes != null ? Genes.WarmthDrainMult : 1f);
        else if (storm)
            warmthRate = -GameConfig.WarmthStormDrain * (Genes != null ? Genes.WarmthDrainMult : 1f);
        else if (onIce)
            warmthRate = GameConfig.WarmthOnIceRegen;
        else
            warmthRate = 0.4f;
        warmth = Mathf.Clamp(warmth + warmthRate * dt, 0f, GameConfig.BaseWarmth);
        if (warmth <= 0f)
            Damage(GameConfig.FreezeHealthDrain * dt, "death_freeze");

        // --- Глубина/давление ---
        if (underwater && depth > (Genes != null ? Genes.SafeDepth : GameConfig.MaxDepthBase))
            Damage(GameConfig.DepthPressureDamagePerSec * dt, "death_depth");

        // --- Реген: сыт и тёпл ---
        if (hunger > 55f && warmth > 45f && health < GameConfig.BaseHealth)
            health = Mathf.Min(GameConfig.BaseHealth, health + GameConfig.HealthRegenPerSec * dt);

        // --- Событие для HUD ---
        GameEvents.RaiseVitals(ToVitals());
    }

    public Vitals ToVitals() => new Vitals
    {
        health = health / GameConfig.BaseHealth,
        oxygen = oxygen / MaxOxygen,
        stamina = stamina / GameConfig.BaseStamina,
        hunger = hunger / GameConfig.BaseHunger,
        warmth = warmth / GameConfig.BaseWarmth,
        underwater = underwater,
        onIce = onIce,
        inBlizzard = _weather != null && _weather.Current == WeatherSystem.State.Blizzard,
        depth = Mathf.Max(0f, depth),
        safeDepth = Genes != null ? Genes.SafeDepth : GameConfig.MaxDepthBase,
        stage = stage,
        growth01 = Growth01
    };

    public void Eat(float hungerValue, float xp, float foodScore)
    {
        hunger = Mathf.Min(GameConfig.BaseHunger, hunger + hungerValue);
        AddGrowth(xp);
        if (GameManager.Instance != null) GameManager.Instance.AddFood(foodScore);
        GameEvents.RaiseAte();
    }
}
