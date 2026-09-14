using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Локализация RU/EN/DE из CSV-ассета (TextAsset — работает в билде).
/// CSV-формат: Key,RU,EN,DE
/// </summary>
public class LocalizationManager : MonoBehaviour
{
    public enum Lang { RU = 0, EN = 1, DE = 2 }
    public static LocalizationManager Instance { get; private set; }
    public Lang CurrentLang { get; private set; } = Lang.RU;
    public UnityEvent<Lang> OnLanguageChanged;

    [Tooltip("CSV-ассет локализации (Assets/Data/Loc/strings.csv)")]
    public TextAsset stringsCsv;

    private readonly Dictionary<string, string[]> _dict = new Dictionary<string, string[]>(128);

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        LoadCSV();
        DetectLanguage();
    }

    private void LoadCSV()
    {
        if (stringsCsv == null)
        {
            stringsCsv = Resources.Load<TextAsset>("strings");
#if UNITY_EDITOR
            if (stringsCsv == null)
                stringsCsv = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Data/Loc/strings.csv");
#endif
        }
        if (stringsCsv == null) { Debug.LogError("[Loc] strings CSV missing"); return; }

        _dict.Clear();
        var lines = stringsCsv.text.Split('\n');
        for (int i = 1; i < lines.Length; i++) // без заголовка
        {
            var line = lines[i].TrimEnd('\r', '\n');
            if (string.IsNullOrWhiteSpace(line)) continue;
            var cols = line.Split(',');
            if (cols.Length >= 4)
            {
                _dict[cols[0].Trim()] = new[] { cols[1].Trim(), cols[2].Trim(), cols[3].Trim() };
            }
        }
    }

    private void DetectLanguage()
    {
        if (PlayerPrefs.HasKey("GameLang") &&
            Enum.TryParse(PlayerPrefs.GetString("GameLang"), out Lang saved))
        {
            SetLanguage(saved, save: false);
            return;
        }
        switch (Application.systemLanguage)
        {
            case SystemLanguage.Russian: SetLanguage(Lang.RU, save: false); break;
            case SystemLanguage.German: SetLanguage(Lang.DE, save: false); break;
            default: SetLanguage(Lang.EN, save: false); break;
        }
    }

    public void SetLanguage(Lang lang, bool save = true)
    {
        CurrentLang = lang;
        if (save)
        {
            PlayerPrefs.SetString("GameLang", lang.ToString());
            PlayerPrefs.Save();
        }
        OnLanguageChanged?.Invoke(lang);
    }

    public string Get(string key)
    {
        if (_dict.TryGetValue(key, out var triple))
        {
            int idx = (int)CurrentLang;
            return idx < triple.Length ? triple[idx] : triple[0];
        }
        return key;
    }

    public static string T(string key) => Instance != null ? Instance.Get(key) : key;
}
