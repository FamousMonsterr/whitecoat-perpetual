using UnityEngine;
using System.IO;
using System;

/// <summary>
/// Система логирования для СИ (Системы Искусственного Интеллекта)
/// Сохраняет все логи работы ИИ, включая скиллы, мемори и агент файлы
/// </summary>
public class AILogManager : MonoBehaviour
{
    private static AILogManager _instance;
    public static AILogManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("AILogManager");
                _instance = go.AddComponent<AILogManager>();
                DontDestroyOnLoad(go);
            }
            return _instance;
        }
    }

    private string logDirectory;
    private string currentLogFile;
    private StreamWriter logWriter;
    private bool isInitialized = false;

    /// <summary>
    /// Инициализация системы логирования
    /// </summary>
    public void Initialize()
    {
        if (isInitialized) return;

        logDirectory = Path.Combine(Application.persistentDataPath, "AI_Logs");
        
        if (!Directory.Exists(logDirectory))
        {
            Directory.CreateDirectory(logDirectory);
        }

        string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
        currentLogFile = Path.Combine(logDirectory, $"AI_Session_{timestamp}.log");
        
        try
        {
            logWriter = new StreamWriter(currentLogFile, true) { AutoFlush = true };
            isInitialized = true;
            Log("=== AI Session Started ===");
            Log($"Session ID: {timestamp}");
            Log($"Unity Version: {Application.unityVersion}");
            Log($"Platform: {Application.platform}");
            Log("=========================");
        }
        catch (Exception e)
        {
            Debug.LogError($"[AI Logger] Failed to initialize log file: {e.Message}");
        }
    }

    /// <summary>
    /// Запись лога общего назначения
    /// </summary>
    public static void Log(string message)
    {
        if (Instance.isInitialized && Instance.logWriter != null)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            string logEntry = $"[{timestamp}] [INFO] {message}";
            Instance.logWriter.WriteLine(logEntry);
            Debug.Log($"[AI LOG] {message}");
        }
        else
        {
            Debug.LogWarning($"[AI LOG] Logger not initialized: {message}");
        }
    }

    /// <summary>
    /// Запись лога с уровнем предупреждения
    /// </summary>
    public static void LogWarning(string message)
    {
        if (Instance.isInitialized && Instance.logWriter != null)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            string logEntry = $"[{timestamp}] [WARNING] {message}";
            Instance.logWriter.WriteLine(logEntry);
            Debug.LogWarning($"[AI LOG] {message}");
        }
    }

    /// <summary>
    /// Запись лога об ошибке
    /// </summary>
    public static void LogError(string message)
    {
        if (Instance.isInitialized && Instance.logWriter != null)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            string logEntry = $"[{timestamp}] [ERROR] {message}";
            Instance.logWriter.WriteLine(logEntry);
            Debug.LogError($"[AI LOG] {message}");
        }
    }

    /// <summary>
    /// Логирование действий скиллов ИИ
    /// </summary>
    public static void LogSkill(string skillName, string action, string details = "")
    {
        Log($"[SKILL] {skillName} - {action}{(string.IsNullOrEmpty(details) ? "" : $": {details}")}");
    }

    /// <summary>
    /// Логирование состояния памяти ИИ
    /// </summary>
    public static void LogMemory(string memoryType, string content)
    {
        Log($"[MEMORY] {memoryType}: {content}");
    }

    /// <summary>
    /// Логирование действий агента
    /// </summary>
    public static void LogAgent(string agentId, string state, string decision = "")
    {
        Log($"[AGENT {agentId}] State: {state}{(string.IsNullOrEmpty(decision) ? "" : $", Decision: {decision}")}");
    }

    /// <summary>
    /// Логирование принятия решений ИИ
    /// </summary>
    public static void LogDecision(string context, string decision, float confidence)
    {
        Log($"[DECISION] Context: {context} | Decision: {decision} | Confidence: {confidence:P2}");
    }

    /// <summary>
    /// Сохранение полного состояния ИИ в отдельный файл
    /// </summary>
    public static void SaveAIState(string stateJson, string stateType = "full")
    {
        if (Instance.isInitialized)
        {
            try
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                string fileName = Path.Combine(Instance.logDirectory, $"AI_State_{stateType}_{timestamp}.json");
                File.WriteAllText(fileName, stateJson);
                Log($"[STATE SAVED] {stateType} state saved to {fileName}");
            }
            catch (Exception e)
            {
                LogError($"Failed to save AI state: {e.Message}");
            }
        }
    }

    /// <summary>
    /// Очистка старых логов (старше указанного количества дней)
    /// </summary>
    public static void CleanupOldLogs(int daysToKeep = 7)
    {
        if (Instance.isInitialized)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(Instance.logDirectory);
                DateTime cutoff = DateTime.Now.AddDays(-daysToKeep);

                foreach (var file in dirInfo.GetFiles("*.log"))
                {
                    if (file.LastWriteTime < cutoff)
                    {
                        file.Delete();
                        Log($"[CLEANUP] Deleted old log: {file.Name}");
                    }
                }
            }
            catch (Exception e)
            {
                LogError($"Failed to cleanup old logs: {e.Message}");
            }
        }
    }

    /// <summary>
    /// Закрытие файла лога при завершении
    /// </summary>
    private void OnApplicationQuit()
    {
        if (isInitialized && logWriter != null)
        {
            Log("=== AI Session Ended ===");
            logWriter.Close();
            logWriter = null;
            isInitialized = false;
        }
    }

    private void OnDisable()
    {
        if (isInitialized && logWriter != null)
        {
            logWriter.Close();
            logWriter = null;
            isInitialized = false;
        }
    }
}
