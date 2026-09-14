using System;

/// <summary>
/// Гены белька: передаются между поколениями, определяют стиль выживания.
/// Каждый ген в диапазоне 0..1; из него выводятся множители характеристик.
/// </summary>
[Serializable]
public class GeneSet
{
    public float breath;      // объём лёгких: +80% кислорода
    public float dive;        // адаптация к глубине: безопасная глубина до +80м
    public float warmth;      // плотность меха: тепло держится дольше
    public float speed;       // мощь хвоста: скорость и рывок
    public float agility;     // манёвренность: увороты дешевле, поворот резче
    public float appetite;    // обмен веществ: больше еды с каждой добычи

    public GeneSet() { }

    public GeneSet(float breath, float dive, float warmth, float speed, float agility, float appetite)
    {
        this.breath = breath; this.dive = dive; this.warmth = warmth;
        this.speed = speed; this.agility = agility; this.appetite = appetite;
    }

    /// <summary>Базовый набор новорождённого первого поколения.</summary>
    public static GeneSet Starter() => new GeneSet(0.15f, 0.10f, 0.20f, 0.15f, 0.15f, 0.15f);

    public GeneSet Clone() => new GeneSet(breath, dive, warmth, speed, agility, appetite);

    public static GeneSet Crossover(GeneSet a, GeneSet b, System.Random rng)
    {
        float Lerp(float x, float y) => x + (float)rng.NextDouble() * (y - x);
        float Clamp01v(float v) => v < 0f ? 0f : (v > 1f ? 1f : v);
        return new GeneSet(
            Clamp01v(Lerp(a.breath, b.breath)),
            Clamp01v(Lerp(a.dive, b.dive)),
            Clamp01v(Lerp(a.warmth, b.warmth)),
            Clamp01v(Lerp(a.speed, b.speed)),
            Clamp01v(Lerp(a.agility, b.agility)),
            Clamp01v(Lerp(a.appetite, b.appetite)));
    }

    public void Mutate(System.Random rng, float magnitude = 0.12f)
    {
        float R() => (float)(rng.NextDouble() * 2.0 - 1.0);
        float Clamp01v(float v) => v < 0f ? 0f : (v > 1f ? 1f : v);
        breath = Clamp01v(breath + R() * magnitude);
        dive = Clamp01v(dive + R() * magnitude);
        warmth = Clamp01v(warmth + R() * magnitude);
        speed = Clamp01v(speed + R() * magnitude);
        agility = Clamp01v(agility + R() * magnitude);
        appetite = Clamp01v(appetite + R() * magnitude * 0.7f);
    }

    // --- Выведенные множители (используют SealStats/SealController) ---
    public float OxygenMult => 1f + breath * 0.8f;
    public float SafeDepth => GameConfig.MaxDepthBase + dive * 80f;
    public float WarmthDrainMult => 1f - warmth * 0.65f;
    public float SpeedMult => 1f + speed * 0.45f;
    public float AgilityMult => 1f + agility * 0.6f;
    public float DodgeCostMult => 1f - agility * 0.45f;
    public float FoodMult => 1f + appetite * 0.5f;

    public float Overall => (breath + dive + warmth + speed + agility + appetite) / 6f;
}
