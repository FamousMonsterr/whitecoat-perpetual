using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Все экраны UI: главное меню, пауза, смерть, сводка поколения.
/// Весь UI строится кодом; ссылки на кнопки сохраняются явно.
/// </summary>
public class MenuController : MonoBehaviour
{
    public static MenuController Instance { get; private set; }

    private Canvas _canvas;
    private Font _font;
    private GameObject _mainMenu, _pauseMenu, _deathScreen, _summaryScreen;
    private Text _mainTitle, _pauseTitle, _deathTitle, _summaryTitle;
    private Text _subtitle, _deathCause, _summaryText;
    private Button _btnStart, _btnLineage, _btnLangMain, _btnQuit;
    private Button _btnResume, _btnLangPause, _btnToMain;
    private Button _btnNext, _btnReborn;
    private LocalizationManager _loc;
    private string _lastDeathKey;

    private void Awake()
    {
        Instance = this;
        _font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        _canvas = GetComponent<Canvas>();
        if (_canvas == null) _canvas = gameObject.AddComponent<Canvas>();
        _canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        if (GetComponent<CanvasScaler>() == null)
        {
            var scaler = gameObject.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920, 1080);
        }
        if (GetComponent<GraphicRaycaster>() == null)
            gameObject.AddComponent<GraphicRaycaster>();

        BuildAll();
    }

    private void Start()
    {
        _loc = LocalizationManager.Instance;
        if (_loc != null) _loc.OnLanguageChanged.AddListener(_ => RefreshAll());
        GameManager.OnStateChanged += HandleState;
        GameEvents.OnDeath += k => _lastDeathKey = k;
        RefreshAll();
        HandleState(GameManager.Instance != null ? GameManager.Instance.State : GameManager.GameState.MainMenu);
    }

    private void OnDestroy()
    {
        GameManager.OnStateChanged -= HandleState;
        GameEvents.OnDeath -= k => _lastDeathKey = k;
        if (Instance == this) Instance = null;
    }

    // ---------- Построение ----------
    private GameObject CreatePanel(string name, Color bg)
    {
        var go = new GameObject(name, typeof(Image));
        go.transform.SetParent(_canvas.transform, false);
        var img = go.GetComponent<Image>();
        img.color = bg;
        img.raycastTarget = true;
        var rt = go.GetComponent<RectTransform>();
        rt.anchorMin = Vector2.zero;
        rt.anchorMax = Vector2.one;
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;
        go.SetActive(false);
        return go;
    }

    private Text CreateTitle(Transform parent, string text, int size, Vector2 pos)
    {
        var go = new GameObject("Title", typeof(Text));
        go.transform.SetParent(parent, false);
        var t = go.GetComponent<Text>();
        t.font = _font;
        t.fontSize = size;
        t.alignment = TextAnchor.MiddleCenter;
        t.color = new Color(0.94f, 0.98f, 1f);
        t.text = text;
        t.fontStyle = FontStyle.Bold;
        var rt = t.rectTransform;
        rt.anchorMin = new Vector2(0.5f, 1f);
        rt.anchorMax = new Vector2(0.5f, 1f);
        rt.anchoredPosition = pos;
        rt.sizeDelta = new Vector2(1400, size + 30);
        return t;
    }

    private Button CreateButton(Transform parent, Vector2 pos, Vector2 size, UnityEngine.Events.UnityAction onClick)
    {
        var go = new GameObject("Button", typeof(Image), typeof(Button));
        go.transform.SetParent(parent, false);
        var img = go.GetComponent<Image>();
        img.color = new Color(0.13f, 0.30f, 0.42f, 0.95f);
        var btn = go.GetComponent<Button>();
        var colors = btn.colors;
        colors.highlightedColor = new Color(0.22f, 0.48f, 0.62f);
        colors.pressedColor = new Color(0.10f, 0.22f, 0.32f);
        btn.colors = colors;
        btn.onClick.AddListener(onClick);
        var rt = go.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.5f, 0.5f);
        rt.anchorMax = new Vector2(0.5f, 0.5f);
        rt.anchoredPosition = pos;
        rt.sizeDelta = size;

        var txtGo = new GameObject("Text", typeof(Text));
        txtGo.transform.SetParent(go.transform, false);
        var t = txtGo.GetComponent<Text>();
        t.font = _font;
        t.fontSize = 30;
        t.alignment = TextAnchor.MiddleCenter;
        t.color = Color.white;
        t.rectTransform.anchorMin = Vector2.zero;
        t.rectTransform.anchorMax = Vector2.one;
        t.rectTransform.offsetMin = Vector2.zero;
        t.rectTransform.offsetMax = Vector2.zero;
        return btn;
    }

    private static void SetBtnText(Button b, string text)
    {
        if (b == null) return;
        var t = b.GetComponentInChildren<Text>();
        if (t != null) t.text = text;
    }

    private void BuildAll()
    {
        // Главное меню
        _mainMenu = CreatePanel("MainMenu", new Color(0.02f, 0.09f, 0.16f, 0.96f));
        _mainTitle = CreateTitle(_mainMenu.transform, "Белёк: Вечный Прибой", 72, new Vector2(0, -180));
        var subtitleGo = new GameObject("Subtitle", typeof(Text));
        subtitleGo.transform.SetParent(_mainMenu.transform, false);
        _subtitle = subtitleGo.GetComponent<Text>();
        _subtitle.font = _font;
        _subtitle.fontSize = 28;
        _subtitle.alignment = TextAnchor.MiddleCenter;
        _subtitle.color = new Color(0.65f, 0.80f, 0.9f);
        var srt = _subtitle.rectTransform;
        srt.anchorMin = new Vector2(0.5f, 1f);
        srt.anchorMax = new Vector2(0.5f, 1f);
        srt.anchoredPosition = new Vector2(0, -270);
        srt.sizeDelta = new Vector2(1200, 40);

        _btnStart = CreateButton(_mainMenu.transform, new Vector2(0, -420), new Vector2(360, 72), StartGame);
        _btnLineage = CreateButton(_mainMenu.transform, new Vector2(0, -510), new Vector2(360, 60), RestartLineage);
        _btnLangMain = CreateButton(_mainMenu.transform, new Vector2(0, -600), new Vector2(360, 60), CycleLanguage);
        _btnQuit = CreateButton(_mainMenu.transform, new Vector2(0, -690), new Vector2(360, 60), Quit);

        // Пауза
        _pauseMenu = CreatePanel("PauseMenu", new Color(0f, 0.04f, 0.1f, 0.82f));
        _pauseTitle = CreateTitle(_pauseMenu.transform, "Пауза", 64, new Vector2(0, -260));
        _btnResume = CreateButton(_pauseMenu.transform, new Vector2(0, -420), new Vector2(340, 68), Resume);
        _btnLangPause = CreateButton(_pauseMenu.transform, new Vector2(0, -505), new Vector2(340, 58), CycleLanguage);
        _btnToMain = CreateButton(_pauseMenu.transform, new Vector2(0, -585), new Vector2(340, 58), ToMainMenu);

        // Экран смерти
        _deathScreen = CreatePanel("DeathScreen", new Color(0.09f, 0.015f, 0.03f, 0.9f));
        _deathTitle = CreateTitle(_deathScreen.transform, "Цикл не прерывается", 58, new Vector2(0, -240));
        var causeGo = new GameObject("Cause", typeof(Text));
        causeGo.transform.SetParent(_deathScreen.transform, false);
        _deathCause = causeGo.GetComponent<Text>();
        _deathCause.font = _font;
        _deathCause.fontSize = 30;
        _deathCause.alignment = TextAnchor.MiddleCenter;
        _deathCause.color = new Color(0.95f, 0.7f, 0.65f);
        var crt = _deathCause.rectTransform;
        crt.anchorMin = new Vector2(0.5f, 1f);
        crt.anchorMax = new Vector2(0.5f, 1f);
        crt.anchoredPosition = new Vector2(0, -340);
        crt.sizeDelta = new Vector2(1200, 60);
        _btnNext = CreateButton(_deathScreen.transform, new Vector2(0, -520), new Vector2(340, 70), ShowSummary);

        // Сводка поколения
        _summaryScreen = CreatePanel("SummaryScreen", new Color(0.015f, 0.06f, 0.11f, 0.96f));
        _summaryTitle = CreateTitle(_summaryScreen.transform, "Новое поколение", 58, new Vector2(0, -200));
        var sumGo = new GameObject("SummaryText", typeof(Text));
        sumGo.transform.SetParent(_summaryScreen.transform, false);
        _summaryText = sumGo.GetComponent<Text>();
        _summaryText.font = _font;
        _summaryText.fontSize = 28;
        _summaryText.alignment = TextAnchor.UpperCenter;
        _summaryText.color = new Color(0.85f, 0.93f, 1f);
        var srt2 = _summaryText.rectTransform;
        srt2.anchorMin = new Vector2(0.5f, 0.5f);
        srt2.anchorMax = new Vector2(0.5f, 0.5f);
        srt2.anchoredPosition = new Vector2(0, 40);
        srt2.sizeDelta = new Vector2(1100, 420);
        _btnReborn = CreateButton(_summaryScreen.transform, new Vector2(0, -330), new Vector2(400, 74), ContinueGeneration);
    }

    // ---------- Логика ----------
    private void HandleState(GameManager.GameState state)
    {
        if (_mainMenu == null) return;
        _mainMenu.SetActive(state == GameManager.GameState.MainMenu);
        _pauseMenu.SetActive(state == GameManager.GameState.Paused);
        _deathScreen.SetActive(state == GameManager.GameState.Death);
        _summaryScreen.SetActive(state == GameManager.GameState.GenerationSummary);
        if (state == GameManager.GameState.GenerationSummary) FillSummary();
        if (state == GameManager.GameState.Death) RefreshDeathCause();
    }

    private void RefreshAll()
    {
        if (_loc == null) return;
        SetBtnText(_btnStart, _loc.Get("menu_start"));
        SetBtnText(_btnLineage, _loc.Get("menu_restart_lineage"));
        SetBtnText(_btnQuit, _loc.Get("menu_quit"));
        SetBtnText(_btnResume, _loc.Get("menu_resume"));
        SetBtnText(_btnToMain, _loc.Get("menu_to_main"));
        SetBtnText(_btnNext, _loc.Get("menu_next"));
        SetBtnText(_btnReborn, _loc.Get("menu_reborn"));
        string langLabel = "RU / EN / DE: " + _loc.CurrentLang.ToString().ToUpper();
        SetBtnText(_btnLangMain, langLabel);
        SetBtnText(_btnLangPause, langLabel);
        if (_mainTitle != null) _mainTitle.text = _loc.Get("menu_title");
        if (_subtitle != null) _subtitle.text = _loc.Get("menu_subtitle");
        if (_pauseTitle != null) _pauseTitle.text = _loc.Get("ui_pause");
        if (_deathTitle != null) _deathTitle.text = _loc.Get("death_title");
        if (_summaryTitle != null) _summaryTitle.text = _loc.Get("summary_title");
        RefreshDeathCause();
    }

    private void RefreshDeathCause()
    {
        if (_deathCause != null && _loc != null && !string.IsNullOrEmpty(_lastDeathKey))
            _deathCause.text = _loc.Get(_lastDeathKey);
    }

    private void StartGame()
    {
        if (GameManager.Instance != null) GameManager.Instance.StartNewRun();
    }

    private void Resume()
    {
        if (GameManager.Instance != null) GameManager.Instance.SetState(GameManager.GameState.Playing);
    }

    private void ToMainMenu()
    {
        if (GameManager.Instance != null) GameManager.Instance.SetState(GameManager.GameState.MainMenu);
    }

    private void RestartLineage()
    {
        if (GameManager.Instance != null) GameManager.Instance.RestartEntireLineage();
    }

    private void Quit()
    {
        if (GameManager.Instance != null) GameManager.Instance.QuitGame();
    }

    private void CycleLanguage()
    {
        if (_loc == null) return;
        var next = (LocalizationManager.Lang)(((int)_loc.CurrentLang + 1) % 3);
        _loc.SetLanguage(next);
        RefreshAll();
    }

    private void ShowSummary()
    {
        if (GameManager.Instance != null) GameManager.Instance.AdvanceGeneration();
    }

    private void ContinueGeneration()
    {
        if (GameManager.Instance != null) GameManager.Instance.ReloadWorld();
    }

    private void FillSummary()
    {
        if (_loc == null || _summaryText == null || GeneticsManager.Instance == null) return;
        var g = GeneticsManager.Instance;
        var cur = g.Current;
        _summaryText.text =
            $"{_loc.Get("summary_generation")}: {g.Generation}\n" +
            $"{_loc.Get("summary_breath")}: {Bar(cur.breath)}\n" +
            $"{_loc.Get("summary_dive")}: {Bar(cur.dive)}\n" +
            $"{_loc.Get("summary_warmth")}: {Bar(cur.warmth)}\n" +
            $"{_loc.Get("summary_speed")}: {Bar(cur.speed)}\n" +
            $"{_loc.Get("summary_agility")}: {Bar(cur.agility)}\n" +
            $"{_loc.Get("summary_appetite")}: {Bar(cur.appetite)}\n" +
            $"{_loc.Get("summary_descendants")}: {g.TotalDescendants}";
    }

    private static string Bar(float v)
    {
        int filled = Mathf.RoundToInt(v * 10f);
        var sb = new System.Text.StringBuilder();
        for (int i = 0; i < 10; i++) sb.Append(i < filled ? "■" : "□");
        return sb.ToString();
    }
}
