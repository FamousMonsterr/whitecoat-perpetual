using NUnit.Framework;

/// <summary>
/// Критические тесты генетики: границы генов, наследование, мутации.
/// Гены — ядро реиграбельности «Вечного Прибоя» (поколения бельчат).
/// </summary>
public class GeneSetTests
{
    [Test]
    public void Starter_AllGenes_WithinUnitRange()
    {
        var g = GeneSet.Starter();
        Assert.That(g.breath, Is.InRange(0f, 1f));
        Assert.That(g.dive, Is.InRange(0f, 1f));
        Assert.That(g.warmth, Is.InRange(0f, 1f));
        Assert.That(g.speed, Is.InRange(0f, 1f));
        Assert.That(g.agility, Is.InRange(0f, 1f));
        Assert.That(g.appetite, Is.InRange(0f, 1f));
        Assert.That(g.Overall, Is.GreaterThan(0f));
    }

    [Test]
    public void Mutate_ExtremeIterations_NeverLeavesUnitRange()
    {
        var rng = new System.Random(20260915);
        var g = new GeneSet(0.999f, 0.001f, 0.5f, 0.99f, 0.01f, 0.5f);
        for (int i = 0; i < 5000; i++)
        {
            g.Mutate(rng, 0.5f);
            Assert.That(g.breath, Is.InRange(0f, 1f), "breath вышел из диапазона");
            Assert.That(g.dive, Is.InRange(0f, 1f), "dive вышел из диапазона");
            Assert.That(g.warmth, Is.InRange(0f, 1f), "warmth вышел из диапазона");
            Assert.That(g.speed, Is.InRange(0f, 1f), "speed вышел из диапазона");
            Assert.That(g.agility, Is.InRange(0f, 1f), "agility вышел из диапазона");
            Assert.That(g.appetite, Is.InRange(0f, 1f), "appetite вышел из диапазона");
        }
    }

    [Test]
    public void Crossover_ChildWithinParentalBounds()
    {
        var rng = new System.Random(7);
        var a = new GeneSet(0.9f, 0.2f, 0.1f, 0.8f, 0.3f, 0.7f);
        var b = new GeneSet(0.1f, 0.8f, 0.9f, 0.2f, 0.6f, 0.3f);
        for (int i = 0; i < 2000; i++)
        {
            var c = GeneSet.Crossover(a, b, rng);
            Assert.That(c.breath, Is.InRange(0.1f, 0.9f));
            Assert.That(c.dive, Is.InRange(0.2f, 0.8f));
            Assert.That(c.warmth, Is.InRange(0.1f, 0.9f));
            Assert.That(c.speed, Is.InRange(0.2f, 0.8f));
            Assert.That(c.agility, Is.InRange(0.3f, 0.6f));
            Assert.That(c.appetite, Is.InRange(0.3f, 0.7f));
        }
    }

    [Test]
    public void DerivedMultipliers_ConsistentWithFormulas()
    {
        var g = new GeneSet(0.5f, 0.5f, 0.5f, 0.5f, 0.5f, 0.5f);
        Assert.That(g.OxygenMult, Is.EqualTo(1.4f).Within(0.001f));
        Assert.That(g.SpeedMult, Is.EqualTo(1.225f).Within(0.001f));
        Assert.That(g.FoodMult, Is.EqualTo(1.25f).Within(0.001f));
        Assert.That(g.SafeDepth, Is.EqualTo(GameConfig.MaxDepthBase + 40f).Within(0.001f));
    }

    [Test]
    public void Clone_IndependentCopy()
    {
        var g = GeneSet.Starter();
        var c = g.Clone();
        c.speed = 0.99f;
        Assert.That(g.speed, Is.Not.EqualTo(c.speed));
    }
}
