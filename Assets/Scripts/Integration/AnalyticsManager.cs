using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AnalyticsManager : MonoBehaviour
{
    public static AnalyticsManager Instance { get; private set; }
    public bool IsReady { get; private set; }

    async void Awake() {
        Instance = this;
        try {
            await UnityServices.InitializeAsync();
            IsReady = true;
            TrackEvent("session_start", new Dictionary<string, object> {
                { "version", Application.version },
                { "platform", Application.platform.ToString() }
            });
        } catch (System.Exception e) {
            Debug.LogError($"[Analytics] Init failed: {e.Message}");
        }
    }

    public static void TrackEvent(string name, Dictionary<string, object> data = null) {
        if (Instance == null || !Instance.IsReady) return;
        AnalyticsService.Instance.RecordEvent(name, data ?? new Dictionary<string, object>());
    }
    
    void OnEnable() => Application.logMessageReceived += HandleLog;
    void OnDisable() => Application.logMessageReceived -= HandleLog;

    void HandleLog(string log, string trace, LogType type) {
        if (type == LogType.Exception) {
            TrackEvent("crash_report", new Dictionary<string, object> { { "message", log } });
        }
    }
}
