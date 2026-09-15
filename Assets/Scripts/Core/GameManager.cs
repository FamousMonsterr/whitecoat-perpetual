using System;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Главный менеджер: состояния игры, пауза, цикл поколений.
/// Сцена перезагружается между поколениями; GeneticsManager живёт между сценами.
/// </summary>
public class GameManager : MonoBehaviour
{
    public enum GameState { MainMenu, Playing, Paused, Evolution, Death, GenerationSummary }

    public static GameManager Instance { get; private set; }
    public GameState State { get; private set; } = GameState.MainMenu;

    public float RunTime { get; private set; }
    public float RunFood { get; private set; }
    public float RunBestDepth { get; private set; }

    public static event Action<GameState> OnStateChanged;

    private float _timeScaleBefore = 1f;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        Time.timeScale = 1f;
        Application.targetFrameRate = 60;
        QualitySettings.vSyncCount = 1;
        // Диагностика запуска: реальный GPU/API в Player.log (используется smoke-тестом CI)
        Debug.Log($"[Boot] GPU: {SystemInfo.graphicsDeviceName} ({SystemInfo.graphicsDeviceType}), " +
                  $"API: {SystemInfo.graphicsAPIType}, VRAM: {SystemInfo.graphicsMemorySize}MB, " +
                  $"Unity: {Application.unityVersion}, Platform: {Application.platform}");
    }

    private void Start()
    {
        GameEvents.OnDeath += HandleDeath;
        SetState(GameState.MainMenu);
    }

    private void OnDestroy()
    {
        if (Instance == this) GameEvents.OnDeath -= HandleDeath;
    }

    public void SetState(GameState s)
    {
        State = s;
        Time.timeScale = (s == GameState.Paused || s == GameState.MainMenu) ? 0f : 1f;
        OnStateChanged?.Invoke(s);
    }

    public void StartNewRun()
    {
        RunTime = 0; RunFood = 0; RunBestDepth = 0;
        SetState(GameState.Playing);
        GameEvents.RaiseGenerationStarted(GeneticsManager.Instance.Generation,
            GeneticsManager.Instance.Current);
    }

    public void TogglePause()
    {
        if (State == GameState.Playing) SetState(GameState.Paused);
        else if (State == GameState.Paused) SetState(GameState.Playing);
    }

    public void AddFood(float v) => RunFood += v;

    public void ReportDepth(float depth)
    {
        if (depth > RunBestDepth) RunBestDepth = depth;
    }

    private void HandleDeath(string causeKey)
    {
        if (State == GameState.Death) return;
        RunTime = Time.timeSinceLevelLoad;
        SetState(GameState.Death);
    }

    /// <summary>Следующее поколение: гены наследуются, мир перегенерируется.</summary>
    public void AdvanceGeneration()
    {
        var gm = GeneticsManager.Instance;
        gm.BeginNextGeneration(RunFood, RunBestDepth);
        SeaRandom.Reroll(); // новое море — новая ледовая обстановка
        SetState(GameState.GenerationSummary);
        // Сцена перезагрузится после показа сводки (MenuController вызывает Continue)
    }

    public void ReloadWorld()
    {
        _timeScaleBefore = 1f;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RestartEntireLineage()
    {
        GeneticsManager.Instance.RestartLineage();
        SeaRandom.Reroll();
        ReloadWorld();
    }

    public void QuitGame()
    {
        GeneticsManager.Instance?.Save();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    private void Update()
    {
        if (State == GameState.Playing)
            RunTime += Time.deltaTime;
    }
}
