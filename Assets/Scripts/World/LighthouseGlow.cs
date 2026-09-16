using UnityEngine;
using Whitecoat.World;

/// <summary>
/// Маяк хаба реагирует на жемчуг (мир отвечает на прогресс ребёнка —
/// петля «действие → реакция мира» из SPYRO-анализа): свет усиливается
/// с ростом счёта, на порогах — короткая вспышка.
/// </summary>
public class LighthouseGlow : MonoBehaviour
{
    [SerializeField] private Renderer lampRenderer;      // лампа (сфера)
    [SerializeField] private Light lampLight;            // точечный свет
    [SerializeField] private int[] thresholds = { 25, 75, 150 };
    [SerializeField] private Color baseGlow = new Color(1f, 0.85f, 0.55f);

    private int _reached;

    private void Start()
    {
        if (PearlLedger.Instance != null)
        {
            PearlLedger.Instance.OnCollected += HandleCollected;
            HandleCollected(PearlLedger.Instance.Total, 0); // восстановление после загрузки
        }
    }

    private void OnDestroy()
    {
        if (PearlLedger.Instance != null)
            PearlLedger.Instance.OnCollected -= HandleCollected;
    }

    private void HandleCollected(int total, int streak)
    {
        if (lampLight != null)
            lampLight.intensity = 1.2f + Mathf.Clamp01(total / 300f) * 2.5f;

        for (int i = 0; i < thresholds.Length; i++)
        {
            if (total >= thresholds[i] && _reached <= i)
            {
                _reached = i + 1;
                Flash();
                Debug.Log($"[LighthouseGlow] threshold {thresholds[i]} reached — flash!");
            }
        }
    }

    private void Flash()
    {
        if (lampRenderer != null && lampRenderer.material != null
            && lampRenderer.material.HasProperty("_EmissionColor"))
        {
            lampRenderer.material.EnableKeyword("_EMISSION");
            lampRenderer.material.SetColor("_EmissionColor", baseGlow * 4f);
        }
    }
}
