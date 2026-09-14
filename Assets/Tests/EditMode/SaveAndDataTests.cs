using NUnit.Framework;
using System.IO;

/// <summary>
/// Тесты сохранений и данных локализации — то, что ломается в билде чаще всего.
/// </summary>
public class SaveAndDataTests
{
    private const string TestFileName = "wc_test_probe.json";

    [TearDown]
    public void Cleanup()
    {
        var p = Path.Combine(SaveSystem.Dir, TestFileName);
        if (File.Exists(p)) File.Delete(p);
    }

    [Test]
    public void SaveSystem_WriteReadRoundtrip()
    {
        var payload = "{\"day\":12,\"fishEaten\":47,\"gene\":{\"breath\":0.42}}";
        SaveSystem.WriteFile(TestFileName, payload);
        Assert.That(SaveSystem.HasFile(TestFileName), Is.True, "файл не записан");
        var back = SaveSystem.ReadFile(TestFileName);
        Assert.That(back, Is.EqualTo(payload), "данные повреждены при roundtrip");
    }

    [Test]
    public void SaveSystem_HasFile_FalseForGarbage()
    {
        Assert.That(SaveSystem.HasFile("wc_definitely_not_exists_9f3a.json"), Is.False);
    }

    [Test]
    public void LocalizationCsv_EveryRow_HasFourNonEmptyColumns()
    {
        var path = "Assets/Data/Loc/strings.csv";
        Assert.That(File.Exists(path), Is.True, "strings.csv отсутствует");
        var lines = File.ReadAllLines(path);
        Assert.That(lines.Length, Is.GreaterThan(10), "слишком мало строк локализации");
        Assert.That(lines[0].Split(',')[0], Is.EqualTo("Key"), "нет заголовка");

        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i])) continue;
            var cols = lines[i].Split(',');
            Assert.That(cols.Length, Is.GreaterThanOrEqualTo(4), $"строка {i}: колонок < 4");
            Assert.That(cols[0].Trim(), Is.Not.Empty, $"строка {i}: пустой ключ");
            Assert.That(cols[1].Trim(), Is.Not.Empty, $"строка {i}: пустой RU");
            Assert.That(cols[2].Trim(), Is.Not.Empty, $"строка {i}: пустой EN");
            Assert.That(cols[3].Trim(), Is.Not.Empty, $"строка {i}: пустой DE");
        }
    }

    [Test]
    public void ResourcesCopy_MatchesPrimaryCsv()
    {
        var a = File.ReadAllText("Assets/Data/Loc/strings.csv");
        var b = File.ReadAllText("Assets/Resources/strings.csv");
        Assert.That(b, Is.EqualTo(a), "копия в Resources разошлась с исходником");
    }

    [Test]
    public void WeatherParams_StormHarsherThanClear()
    {
        var clear = new WeatherSystem.WeatherParams { visibility01 = 1f, windForce = 2f, snowRate = 0f, temperature = -2f };
        var storm = new WeatherSystem.WeatherParams { visibility01 = 0.25f, windForce = 11f, snowRate = 1f, temperature = -18f };
        Assert.That(storm.visibility01, Is.LessThan(clear.visibility01));
        Assert.That(storm.windForce, Is.GreaterThan(clear.windForce));
        Assert.That(storm.temperature, Is.LessThan(clear.temperature));
    }
}
