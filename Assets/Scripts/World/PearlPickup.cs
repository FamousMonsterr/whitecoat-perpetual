using UnityEngine;
using Whitecoat.World;

/// <summary>
/// Жемчужина — основной коллектибл (аналог кристаллов SPYRO).
/// Подбирается касанием, даёт серии (комбо-звон нарастает), пишет в
/// PearlLedger. Всегда вращается и мягко светится — заметность без текста.
/// </summary>
public class PearlPickup : MonoBehaviour
{
    [SerializeField] private int value = 1;
    [SerializeField] private float spinSpeed = 90f;
    [SerializeField] private float bobAmplitude = 0.15f;
    [SerializeField] private float bobSpeed = 1.6f;
    [SerializeField] private AudioClip collectSfx;

    private Vector3 _basePos;
    private float _phase;
    private bool _taken;

    private void Awake()
    {
        _basePos = transform.position;
        _phase = Random.value * Mathf.PI * 2f;
        var col = GetComponent<SphereCollider>();
        if (col == null)
        {
            col = gameObject.AddComponent<SphereCollider>();
        }
        col.isTrigger = true;
        col.radius = Mathf.Max(col.radius, 1.1f); // щедрый радиус подбора (5 лет)
    }

    private void Update()
    {
        if (_taken) return;
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime, Space.Self);
        var p = transform.position;
        p.y = _basePos.y + Mathf.Sin(Time.time * bobSpeed + _phase) * bobAmplitude;
        transform.position = p;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_taken) return;
        var seal = other.GetComponentInParent<SealController>();
        if (seal == null) return;

        _taken = true;
        if (PearlLedger.Instance != null) PearlLedger.Instance.Collect(value, transform.position);

        if (collectSfx != null && Camera.main != null)
            AudioSource.PlayClipAtPoint(collectSfx, transform.position);

        // Мини-праздник: пузырь-всплеск
        SpawnBurst();
        // Исчезаем только визуально: объект остаётся до конца сессии как «пусто»
        foreach (var r in GetComponentsInChildren<Renderer>()) r.enabled = false;
        enabled = false;
    }

    private void SpawnBurst()
    {
        var go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        go.name = "PearlBurst";
        Destroy(go.GetComponent<Collider>());
        go.transform.position = transform.position;
        go.transform.localScale = Vector3.one * 0.25f;
        var mr = go.GetComponent<MeshRenderer>();
        if (mr.material != null)
        {
            mr.material.color = new Color(1f, 0.98f, 0.9f, 0.9f);
            if (mr.material.HasProperty("_EmissionColor"))
            {
                mr.material.EnableKeyword("_EMISSION");
                mr.material.SetColor("_EmissionColor", new Color(1f, 0.95f, 0.75f) * 2f);
            }
        }
        // Простое расширение-затухание без зависимости от партиклов (CI-safe)
        StartCoroutine(BurstAndDie(go.transform));
    }

    private System.Collections.IEnumerator BurstAndDie(Transform t)
    {
        float t0 = 0f;
        while (t0 < 0.45f)
        {
            t0 += Time.deltaTime;
            t.localScale = Vector3.one * (0.25f + t0 * 1.4f);
            yield return null;
        }
        Destroy(t.gameObject);
    }
}
