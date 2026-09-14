using UnityEngine;

/// <summary>
/// Стадии развития: Белёк → Хоклан → Седун → Взрослый.
/// Смена визуала (модель белька/взрослого), масштаба и мелодии питчинга лая.
/// </summary>
public class SealStageSystem : MonoBehaviour
{
    [Header("Модели стадий (назначает SceneBuilder)")]
    public GameObject pupVisual;    // стадии 1-2
    public GameObject adultVisual;  // стадии 3-4

    [Header("Масштаб по стадиям")]
    public float[] stageScale = { 1.0f, 1.15f, 1.35f, 1.6f };

    private SealStats _stats;
    private int _currentStage = -1;

    private void Start()
    {
        _stats = GetComponent<SealStats>();
        if (_stats != null) ApplyStage(_stats.stage);
        GameEvents.OnStageChanged += HandleStage;
        // Восстановление стадии при перезагрузке сцены нового поколения? Нет — новое поколение начинается с белька
    }

    private void OnDestroy()
    {
        GameEvents.OnStageChanged -= HandleStage;
    }

    private void HandleStage(int stage) => ApplyStage(stage);

    private void ApplyStage(int stage)
    {
        if (stage == _currentStage) return;
        _currentStage = stage;
        bool adult = stage >= 3;
        if (pupVisual != null) pupVisual.SetActive(!adult);
        if (adultVisual != null) adultVisual.SetActive(adult);

        int idx = Mathf.Clamp(stage - 1, 0, stageScale.Length - 1);
        transform.localScale = Vector3.one * stageScale[idx];

        // Подгон коллайдера под масштаб
        var col = GetComponent<CapsuleCollider>();
        if (col != null)
        {
            col.radius = 0.42f * stageScale[idx];
            col.height = 1.55f * stageScale[idx];
        }

        if (stage >= 2 && stage <= 4)
            AudioDirector.PlaySfx("evolve");
    }
}
