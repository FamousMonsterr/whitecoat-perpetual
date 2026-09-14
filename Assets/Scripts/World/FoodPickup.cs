using UnityEngine;

/// <summary>
/// Корм: криль-облака и моллюски. Триггер-подбор, респаун через N секунд.
/// </summary>
[RequireComponent(typeof(Collider))]
public class FoodPickup : MonoBehaviour
{
    public FoodType type = FoodType.Krill;
    public float respawnSec = 30f;
    public float bobAmp = 0.15f;

    private Collider _col;
    private Renderer[] _renderers;
    private ParticleSystem _ps;
    private Vector3 _basePos;
    private float _phase;
    private bool _consumed;

    private void Awake()
    {
        _col = GetComponent<Collider>();
        _col.isTrigger = true;
        _renderers = GetComponentsInChildren<Renderer>();
        _ps = GetComponentInChildren<ParticleSystem>();
        _basePos = transform.position;
        _phase = Random.value * 6.28f;
    }

    private void Update()
    {
        if (_consumed) return;
        transform.position = _basePos + Vector3.up * (Mathf.Sin(Time.time * 1.3f + _phase) * bobAmp);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_consumed) return;
        var seal = other.GetComponentInParent<SealController>();
        if (seal == null) return;
        seal.TryEat(type);
        Consume();
    }

    private void Consume()
    {
        _consumed = true;
        _col.enabled = false;
        foreach (var r in _renderers) if (r != null) r.enabled = false;
        if (_ps != null) _ps.Stop();
        Invoke(nameof(Respawn), respawnSec);
    }

    private void Respawn()
    {
        _consumed = false;
        _col.enabled = true;
        foreach (var r in _renderers) if (r != null) r.enabled = true;
        if (_ps != null) _ps.Play();
    }
}
