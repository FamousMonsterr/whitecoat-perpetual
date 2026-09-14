using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// HUD: полосы кислорода/стамины/голода/тепла, глубина, стадия, погода,
/// индикатор угрозы, компас до ближайшей проруби. Весь UI строится кодом.
/// </summary>
public class HUDController : MonoBehaviour
{
    public static HUDController Instance { get; private set; }

    private Canvas _canvas;
    private Text _stageLabel, _weatherLabel, _depthLabel, _genLabel;
    private Bar _oxygen, _stamina, _hunger, _warmth, _health;
    private Image _threatVignette;
    private Text _hintLabel;
    private float _threatLevel;
    private WeatherSystem _weather;
    private LocalizationManager _loc;

    public class Bar
    {
        public RectTransform fill;
        public Image fillImage;
        public CanvasGroup group;
        public Color color;
    }

    private void Awake()
    {
        Instance = this;
        BuildUI();
    }

    private void OnDestroy() { if (Instance == this) Instance = null; }

    private void Start()
    {
        _weather = WeatherSystem.Instance;
        _loc = LocalizationManager.Instance;
        GameEvents.OnThreatLevel += t => _threatLevel = t;
        if (_loc != null) _loc.OnLanguageChanged.AddListener(_ => RefreshLabels());
        RefreshLabels();
    }

    private Font BuiltinFont =>
        Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");

    private void BuildUI()
    {
        var go = gameObject;
        _canvas = go.GetComponent<Canvas>();
        if (_canvas == null) _canvas = go.AddComponent<Canvas>();
        _canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        if (go.GetComponent<CanvasScaler>() == null)
        {
            var scaler = go.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1920, 1080);
            scaler.matchWidthOrHeight = 0.5f;
        }
        if (go.GetComponent<GraphicRaycaster>() == null)
            go.AddComponent<GraphicRaycaster>();

        Font font = BuiltinFont;

        // --- Полосы слева сверху ---
        _oxygen = CreateBar("Oxygen", new Vector2(24, -24), new Color(0.25f, 0.85f, 1f), font, "ui_oxygen");
        _stamina = CreateBar("Stamina", new Vector2(24, -64), new Color(1f, 0.85f, 0.3f), font, "ui_stamina");
        _hunger = CreateBar("Hunger", new Vector2(24, -104), new Color(1f, 0.55f, 0.25f), font, "ui_food");
        _warmth = CreateBar("Warmth", new Vector2(24, -144), new Color(1f, 0.35f, 0.3f), font, "ui_warmth");
        _health = CreateBar("Health", new Vector2(24, -184), new Color(0.95f, 0.25f, 0.35f), font, "ui_health");

        // --- Текст справа сверху ---
        _stageLabel = CreateText("Stage", new Vector2(-24, -24), TextAnchor.UpperRight, font, 30);
        _genLabel = CreateText("Gen", new Vector2(-24, -60), TextAnchor.UpperRight, font, 24);
        _weatherLabel = CreateText("Weather", new Vector2(-24, -92), TextAnchor.UpperRight, font, 24);
        _depthLabel = CreateText("Depth", new Vector2(-24, -124), TextAnchor.UpperRight, font, 24);

        // --- Подсказка снизу ---
        _hintLabel = CreateText("Hint", new Vector2(0, -60), TextAnchor.LowerCenter, font, 24);
        var hintRect = _hintLabel.GetComponent<RectTransform>();
        hintRect.anchorMin = new Vector2(0.5f, 0f);
        hintRect.anchorMax = new Vector2(0.5f, 0f);
        hintRect.anchoredPosition = new Vector2(0, 46);

        // --- Виньетка угрозы ---
        var threatGo = new GameObject("ThreatVignette", typeof(Image));
        threatGo.transform.SetParent(_canvas.transform, false);
        _threatVignette = threatGo.GetComponent<Image>();
        _threatVignette.rectTransform.anchorMin = Vector2.zero;
        _threatVignette.rectTransform.anchorMax = Vector2.one;
        _threatVignette.rectTransform.offsetMin = Vector2.zero;
        _threatVignette.rectTransform.offsetMax = Vector2.zero;
        _threatVignette.color = new Color(0.8f, 0.05f, 0.05f, 0f);
        _threatVignette.raycastTarget = false;
        threatGo.transform.SetAsFirstSibling();
    }

    private Bar CreateBar(string name, Vector2 pos, Color color, Font font, string locKey)
    {
        var root = new GameObject("Bar_" + name, typeof(Image));
        root.transform.SetParent(_canvas.transform, false);
        var rt = root.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0, 1);
        rt.anchorMax = new Vector2(0, 1);
        rt.pivot = new Vector2(0, 1);
        rt.anchoredPosition = pos;
        rt.sizeDelta = new Vector2(320, 26);
        var bg = root.GetComponent<Image>();
        bg.color = new Color(0f, 0f, 0f, 0.45f);
        bg.raycastTarget = false;

        var fillGo = new GameObject("Fill", typeof(Image));
        fillGo.transform.SetParent(root.transform, false);
        var fillRt = fillGo.GetComponent<RectTransform>();
        fillRt.anchorMin = Vector2.zero;
        fillRt.anchorMax = Vector2.one;
        fillRt.offsetMin = new Vector2(3, 3);
        fillRt.offsetMax = new Vector2(-3, -3);
        var fillImg = fillGo.GetComponent<Image>();
        fillImg.color = color;
        fillImg.raycastTarget = false;

        var labelGo = new GameObject("Label", typeof(Text));
        labelGo.transform.SetParent(root.transform, false);
        var lt = labelGo.GetComponent<Text>();
        lt.font = font;
        lt.fontSize = 17;
        lt.alignment = TextAnchor.MiddleLeft;
        lt.color = Color.white;
        lt.rectTransform.anchorMin = Vector2.zero;
        lt.rectTransform.anchorMax = Vector2.one;
        lt.rectTransform.offsetMin = new Vector2(10, 0);
        lt.rectTransform.offsetMax = new Vector2(0, 0);
        lt.text = _loc != null ? _loc.Get(locKey) : locKey;
        lt.raycastTarget = false;

        return new Bar { fill = fillRt, fillImage = fillImg, color = color };
    }

    private Text CreateText(string name, Vector2 pos, TextAnchor anchor, Font font, int size)
    {
        var go = new GameObject("Text_" + name, typeof(Text));
        go.transform.SetParent(_canvas.transform, false);
        var t = go.GetComponent<Text>();
        t.font = font;
        t.fontSize = size;
        t.alignment = anchor;
        t.color = Color.white;
        t.raycastTarget = false;
        var shadow = go.AddComponent<Outline>();
        shadow.effectColor = new Color(0, 0, 0, 0.7f);
        var rt = t.rectTransform;
        rt.anchorMin = new Vector2(1, 1);
        rt.anchorMax = new Vector2(1, 1);
        rt.pivot = new Vector2(1, 1);
        rt.anchoredPosition = pos;
        rt.sizeDelta = new Vector2(460, 34);
        return t;
    }

    private void RefreshLabels()
    {
        if (_loc == null) return;
        if (_oxygen != null) SetBarLabel(_oxygen, _loc.Get("ui_oxygen"));
        if (_stamina != null) SetBarLabel(_stamina, _loc.Get("ui_stamina"));
        if (_hunger != null) SetBarLabel(_hunger, _loc.Get("ui_food"));
        if (_warmth != null) SetBarLabel(_warmth, _loc.Get("ui_warmth"));
        if (_health != null) SetBarLabel(_health, _loc.Get("ui_health"));
    }

    private void SetBarLabel(Bar bar, string text)
    {
        // Подпись лежит третьим ребёнком бара
        if (bar.fill.transform.parent.childCount >= 3)
        {
            var label = bar.fill.transform.parent.GetChild(2).GetComponent<Text>();
            if (label != null) label.text = text;
        }
    }

    private static readonly string[] StageKeys = { "ui_stage_pup", "ui_stage_beater", "ui_stage_jacket", "ui_stage_adult" };

    private void Update()
    {
        var stats = SealStats.Instance;
        if (stats == null || GameManager.Instance == null) return;
        bool hudVisible = GameManager.Instance.State == GameManager.GameState.Playing ||
                          GameManager.Instance.State == GameManager.GameState.Evolution;
        _canvas.enabled = hudVisible;
        if (!hudVisible) return;

        var v = stats.ToVitals();
        SetBar(_oxygen, v.oxygen);
        SetBar(_stamina, v.stamina);
        SetBar(_hunger, v.hunger);
        SetBar(_warmth, v.warmth);
        SetBar(_health, v.health);

        if (_loc != null)
        {
            int stageIdx = Mathf.Clamp(v.stage - 1, 0, StageKeys.Length - 1);
            _stageLabel.text = _loc.Get(StageKeys[stageIdx]) +
                               (v.stage < 4 ? $"  {Mathf.RoundToInt(v.growth01 * 100)}%" : "");
            _genLabel.text = _loc.Get("ui_generation") + " " + GeneticsManager.Instance.Generation;
            _weatherLabel.text = _weather != null ? _loc.Get(_weather.StateLocKey) : "";
            _depthLabel.text = _loc.Get("ui_depth") + $" {v.depth:0} м";
        }

        // Виньетка угрозы
        if (_threatVignette != null)
        {
            Color c = _threatVignette.color;
            c.a = Mathf.Lerp(c.a, _threatLevel * 0.42f, Time.deltaTime * 5f);
            _threatVignette.color = c;
        }

        // Контекстная подсказка
        if (_hintLabel != null && _loc != null)
        {
            string hint = "";
            if (v.oxygen < 0.35f && v.underwater)
                hint = _loc.Get("hint_breathe");
            else if (v.hunger < 0.25f)
                hint = _loc.Get("hint_hunt");
            else if (v.warmth < 0.25f)
                hint = _loc.Get("hint_warm");
            _hintLabel.text = hint;
        }
    }

    private void SetBar(Bar bar, float v01)
    {
        if (bar?.fill == null) return;
        bar.fill.localScale = new Vector3(Mathf.Clamp01(v01), 1f, 1f);
        // Пульсация при критическом значении
        bool critical = v01 < 0.25f;
        bar.fillImage.color = critical
            ? Color.Lerp(bar.color, Color.white, Mathf.PingPong(Time.time * 3f, 1f) * 0.5f)
            : bar.color;
    }
}
