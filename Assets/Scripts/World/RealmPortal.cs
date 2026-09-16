using UnityEngine;
using Whitecoat.World;

/// <summary>
/// Арка-портал реалма: Белёк подплывает/подбегает к триггеру, замирает на
/// мгновение и переносится в целевой реалм. Возврат — обратный портал у
/// точки появления. Для ребёнка это «прыжок сквозь кольцо пузырей».
/// </summary>
public class RealmPortal : MonoBehaviour
{
    [SerializeField] private RealmId destination = RealmId.WarmCove;
    [SerializeField] private float cooldown = 2f;
    [SerializeField] private ParticleSystem rippleVfx;   // опционально
    [SerializeField] private AudioClip travelSfx;        // опционально

    private float _lastUse = -99f;
    private static readonly int EmissionId = Shader.PropertyToID("_EmissionColor");

    private void Reset()
    {
        var col = GetComponent<Collider>();
        if (col == null) { col = gameObject.AddComponent<BoxCollider>(); col.isTrigger = true; }
        col.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Time.time - _lastUse < cooldown) return;
        var seal = other.GetComponentInParent<SealController>();
        if (seal == null) return;
        var rm = RealmManager.Instance;
        if (rm == null || rm.Current == destination) return;

        _lastUse = Time.time;
        if (rippleVfx != null) rippleVfx.Play();
        if (travelSfx != null && Camera.main != null)
            AudioSource.PlayClipAtPoint(travelSfx, Camera.main.transform.position);

        rm.TravelTo(destination, seal.transform);
    }

    /// <summary>Подсветка портала (мягкое свечение — заметность для 5 лет).</summary>
    public void SetGlow(Color c)
    {
        var r = GetComponent<Renderer>();
        if (r == null || r.sharedMaterial == null) return;
        var m = r.material;
        if (m.HasProperty(EmissionId))
        {
            m.EnableKeyword("_EMISSION");
            m.SetColor(EmissionId, c * 1.6f);
        }
    }
}
