using UnityEngine;

/// <summary>
/// Центральная конфигурация баланса игры «Белёк: Вечный Прибой».
/// Все тюнинговые константы в одном месте — удобно для плейтестов и правок критиком.
/// </summary>
public static class GameConfig
{
    // --- Мир ---
    public const float WaterLevel = 0f;           // уровень воды (Y)
    public const float SeaFloorY = -26f;          // дно океана
    public const int ChunkSize = 48;              // размер чанка, м
    public const int ChunkRadius = 3;             // радиус прогрузки (7x7)
    public const int MaxSpawnsPerFrame = 4;       // бюджет спавна в кадр
    public const float ChunkUnloadPad = 1.5f;     // выгрузка за радиусом+пад

    // --- Игрок: виталы ---
    public const float BaseHealth = 100f;
    public const float BaseOxygen = 45f;          // сек под водой
    public const float BaseStamina = 100f;
    public const float BaseHunger = 100f;         // тает ~ за 6 минут
    public const float BaseWarmth = 100f;
    public const float OxygenDrainPerSec = 1.0f;
    public const float OxygenRefillPerSec = 14f;
    public const float HungerDrainPerSec = 0.28f;
    public const float HungerSwimMult = 1.6f;     // активное плавание ест быстрее
    public const float HungerDrainBoostMult = 2.2f;
    public const float WarmthInWaterDrain = 1.1f;   // вода холодная
    public const float WarmthBlizzardDrain = 3.2f;  // пурга на льду
    public const float WarmthStormDrain = 1.6f;
    public const float WarmthOnIceRegen = 2.2f;     // сушиться на льду
    public const float StarvationHealthDrain = 2.5f;
    public const float FreezeHealthDrain = 4.0f;
    public const float DrownHealthDrain = 12f;
    public const float HealthRegenPerSec = 1.6f;    // если сыт и тёпл

    // --- Игрок: движение ---
    public const float SwimSpeed = 4.2f;
    public const float SwimBoostSpeed = 7.6f;      // Shift, жрёт стамину
    public const float SwimAcceleration = 14f;
    public const float SwimDrag = 2.6f;
    public const float BuoyancyForce = 26f;        // к поверхности
    public const float SinkForce = 7f;
    public const float WaddleSpeed = 2.1f;
    public const float DodgeImpulse = 9f;          // рывок-уворот
    public const float DodgeStaminaCost = 30f;
    public const float BoostStaminaPerSec = 22f;
    public const float StaminaRegenPerSec = 16f;
    public const float TurnResponsiveness = 9f;
    public const float MaxDepthBase = 30f;          // без генов глубже больно
    public const float DepthPressureDamagePerSec = 3.5f;

    // --- Рост и стадии ---
    public const float XPPerFish = 8f;
    public const float XPPerKrill = 2.5f;
    public const float XPPerClam = 5f;
    public const float Stage2XP = 40f;   // Хоклан
    public const float Stage3XP = 110f;  // Седун
    public const float Stage4XP = 200f;  // Взрослый

    // --- Касатка ---
    public const float OrcaPatrolSpeed = 3.2f;
    public const float OrcaChaseSpeed = 8.4f;
    public const float OrcaDetectRange = 42f;
    public const float OrcaAttackRange = 3.6f;
    public const float OrcaBiteDamage = 38f;
    public const float OrcaChaseGiveUpSec = 13f;
    public const float OrcaRetreatSec = 18f;
    public const float OrcaRespawnSecMin = 55f;
    public const float OrcaRespawnSecMax = 110f;

    // --- Погода ---
    public const float WeatherTransitionSec = 6f;
    public const float WeatherMinDuration = 40f;
    public const float WeatherMaxDuration = 110f;

    // --- Сутки ---
    public const float DayLengthSec = 480f;       // 8 минут полный цикл

    // --- Еда ---
    public const float FishHungerValue = 26f;
    public const float KrillHungerValue = 7f;
    public const float ClamHungerValue = 16f;

    // --- Лай ---
    public const float BarkCooldown = 6f;
    public const float BarkAttractRadius = 16f;
    public const float BarkAlertOrcaRadius = 34f;
    public const float BarkRevealSec = 5f;

    // --- Аудио (громкости 0..1) ---
    public const float MasterVolume = 0.9f;
    public const float MusicVolume = 0.55f;
    public const float SfxVolume = 0.85f;
}
