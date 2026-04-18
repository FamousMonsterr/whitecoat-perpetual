using UnityEngine;
using System.Collections.Generic;
using System.IO;
using UnityEngine.Events;

public class LocalizationManager : MonoBehaviour
{
    public enum Lang { RU, EN, DE }
    public static LocalizationManager Instance { get; private set; }
    public Lang CurrentLang { get; private set; } = Lang.RU;
    public UnityEvent<Lang> OnLanguageChanged;

    private Dictionary<string, string[]> dict = new();

    void Awake() {
        Instance = this;
        LoadCSV();
        DetectLanguage();
    }

    void LoadCSV() {
        string path = Path.Combine(Application.dataPath, "Data/Loc/strings.csv");
        if (!File.Exists(path)) { Debug.LogError("Loc CSV missing: " + path); return; }
        var lines = File.ReadAllLines(path);
        for (int i = 1; i < lines.Length; i++) {
            var cols = lines[i].Split(',');
            if (cols.Length >= 4) dict[cols[0]] = new[] { cols[1], cols[2], cols[3] };
        }
    }

    void DetectLanguage() {
        if (PlayerPrefs.HasKey("GameLang")) {
            Enum.TryParse(PlayerPrefs.GetString("GameLang"), out Lang saved);
            SetLanguage(saved); return;
        }
        var sys = Application.systemLanguage;
        if (sys == SystemLanguage.Russian) SetLanguage(Lang.RU);
        else if (sys == SystemLanguage.German) SetLanguage(Lang.DE);
        else SetLanguage(Lang.EN);
    }

    public void SetLanguage(Lang lang) {
        CurrentLang = lang;
        OnLanguageChanged?.Invoke(lang);
        PlayerPrefs.SetString("GameLang", lang.ToString());
        PlayerPrefs.Save();
    }

    public string Get(string key) => dict.ContainsKey(key) ? dict[key][(int)CurrentLang] : $"[!{key}]";
}
