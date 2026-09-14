using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;

/// <summary>
/// Аналитика Unity Services + краш-репорты. Деградирует бесшумно офлайн.
/// </summary>
public class AnalyticsManager : MonoBehaviour
{
    public static AnalyticsManager Instance { get; private set; }
    public bool IsReady { get; private set; }

    private async void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        try
        {
            await UnityServices.InitializeAsync();
            IsReady = true;
            Track("session_start", new Dictionary<string, object>
            {
                { "version", Application.version },
                { "platform", Application.platform.ToString() }
            });
        }
        catch (System.Exception e)
        {
            // Офлайн — аналитика просто выключена, это норма
            Debug.Log($"[Analytics] offline: {e.Message}");
        }
    }

    public static void Track(string name, Dictionary<string, object> data = null)
    {
        if (Instance == null || !Instance.IsReady) return;
        try
        {
            // Analytics 5.x API: события создаются как объекты CustomEvent и передаются в RecordEvent.
            var evt = new CustomEvent(name);
            if (data != null)
            {
                foreach (var kv in data)
                {
                    // RecordEvent принимает только примитивы; всё остальное сериализуем в строку.
                    if (kv.Value is string || kv.Value is int || kv.Value is long ||
                        kv.Value is float || kv.Value is double || kv.Value is bool)
                        evt.Add(kv.Key, kv.Value);
                    else
                        evt.Add(kv.Key, kv.Value?.ToString() ?? "null");
                }
            }
            AnalyticsService.Instance.RecordEvent(evt);
        }
        catch (System.Exception) { /* тихо */ }
    }

    private void OnEnable() => Application.logMessageReceived += HandleLog;
    private void OnDisable() => Application.logMessageReceived -= HandleLog;

    private void HandleLog(string log, string trace, LogType type)
    {
        if (type == LogType.Exception)
        {
            Track("crash_report", new Dictionary<string, object> { { "message", log } });
        }
    }
}
