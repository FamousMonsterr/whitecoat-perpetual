using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Льдина: дрейф по ветру/течению, разрушение в шторм (опционально).
/// Верхняя поверхность — ходовая (слой Ice).
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class IceFloe : MonoBehaviour
{
    public static readonly List<IceFloe> Active = new List<IceFloe>();

    [Header("Дрейф")]
    public bool drift = true;
    public float driftSpeed = 0.25f;
    public float bobAmp = 0.05f;
    public bool breakableInStorm;

    public Vector3 HoleOffset { get; set; } = Vector3.zero; // для лунок
    public bool HasHole { get; set; }

    private Rigidbody _rb;
    private WeatherSystem _weather;
    private Vector3 _basePos;
    private float _phase;
    private bool _broken;

    private void OnEnable() { Active.Add(this); }
    private void OnDisable() { Active.Remove(this); }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.useGravity = false;
        _rb.isKinematic = true;
        _phase = Random.value * 6.28f;
    }

    private void Start()
    {
        _weather = WeatherSystem.Instance;
        _basePos = transform.position;
    }

    private void Update()
    {
        if (_broken) return;
        float t = Time.time;
        float wind = _weather != null ? _weather.WindForce : 0f;
        Vector3 windDir = new Vector3(0.8f, 0f, 0.6f).normalized;

        if (drift)
        {
            _basePos += windDir * (driftSpeed + wind * 0.045f) * Time.deltaTime;
        }
        // Качка на волнах
        float bob = Mathf.Sin(t * 1.1f + _phase) * bobAmp * (1f + (_weather != null ? _weather.WaveFactor : 0f) * 2.5f);
        _rb.MovePosition(_basePos + Vector3.up * bob);
        _rb.MoveRotation(Quaternion.Euler(
            Mathf.Sin(t * 0.9f + _phase) * 1.2f * (1f + (_weather != null ? _weather.WaveFactor : 0f) * 3f),
            transform.eulerAngles.y,
            Mathf.Cos(t * 0.8f + _phase * 1.3f) * 1.2f * (1f + (_weather != null ? _weather.WaveFactor : 0f) * 3f)));

        // Шторм ломает слабые льдины
        if (breakableInStorm && !_broken && _weather != null &&
            _weather.Current == WeatherSystem.State.Storm && Random.value < Time.deltaTime * 0.02f)
        {
            Break();
        }
    }

    public void Break()
    {
        if (_broken) return;
        _broken = true;
        AudioDirector.PlaySfx("ice_crack", transform.position);
        // Простое разрушение: прячем и спавним обломки-пену
        var renderers = GetComponentsInChildren<Renderer>();
        foreach (var r in renderers) r.enabled = false;
        foreach (var col in GetComponentsInChildren<Collider>()) col.enabled = false;
        enabled = false;
    }
}
