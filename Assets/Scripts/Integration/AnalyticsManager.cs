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
            if (data != null)
                AnalyticsService.Instance.CustomEvent(name, data);
            else
                AnalyticsService.Instance.CustomEvent(name);
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
