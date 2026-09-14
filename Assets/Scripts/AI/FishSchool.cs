using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Школа сельди: боиды-лайт через Graphics.DrawMeshInstanced.
/// Рыбы flock'ятся вокруг дрейфующего якоря, боятся белька,
/// приплывают на лай (любопытство), съедаются при контакте.
/// </summary>
public class FishSchool : MonoBehaviour
{
    public static readonly List<FishSchool> All = new List<FishSchool>();

    [Header("Конфигурация")]
    public int fishCount = 60;
    public Mesh fishMesh;
    public Material fishMaterial;
    public float schoolRadius = 6f;
    public float swimSpeed = 1.8f;
    public float fleeRadius = 10f;

    private Matrix4x4[] _matrices;
    private Vector3[] _velocities;
    private Vector3 _anchor;
    private Vector3 _anchorVel;
    private Vector4[] _wobble; // xz: фаза, y: скорость
    private bool _matrixDirty = true;
    private Mesh _mesh;
    private Material _mat;
    private Matrix4x4[] _renderBatch;
    private SealController _seal;
    private float _attractTimer;

    private const int BatchSize = 120;

    private void OnEnable() { All.Add(this); }
    private void OnDisable() { All.Remove(this); }

    private void Start()
    {
        _seal = SealController.Instance;
        _anchor = transform.position;
        _matrices = new Matrix4x4[fishCount];
        _velocities = new Vector3[fishCount];
        _wobble = new Vector4[fishCount];
        var rng = new System.Random(GetInstanceID());
        for (int i = 0; i < fishCount; i++)
        {
            _matrices[i] = Matrix4x4.TRS(_anchor + RandomInSphere(rng, schoolRadius),
                Quaternion.Euler(0, rng.Next(0, 360), 0), Vector3.one * Random.Range(0.7f, 1.15f));
            _velocities[i] = Random.onUnitSphere * swimSpeed * 0.5f;
            _wobble[i] = new Vector4((float)rng.NextDouble() * 6.28f, Random.Range(6f, 10f), 0, 0);
        }
        _mesh = fishMesh != null ? fishMesh : null;
        _mat = fishMaterial;
    }

    private static Vector3 RandomInSphere(System.Random rng, float r)
    {
        Vector3 v;
        do { v = new Vector3((float)rng.NextDouble() * 2 - 1, (float)rng.NextDouble() * 2 - 1, (float)rng.NextDouble() * 2 - 1); }
        while (v.sqrMagnitude > 1f);
        return v * r;
    }

    public void Attract(float duration) => _attractTimer = duration;

    private void Update()
    {
        _attractTimer -= Time.deltaTime;
        Vector3 sealPos = _seal != null ? _seal.transform.position : Vector3.zero;
        float distToSeal = _seal != null ? Vector3.Distance(sealPos, _anchor) : float.MaxValue;

        // Якорь дрейфует шумно, держится под водой
        _anchorVel += new Vector3(
            Mathf.PerlinNoise(Time.time * 0.08f, 7.3f) - 0.5f,
            (Mathf.PerlinNoise(Time.time * 0.05f, 2.1f) - 0.5f) * 0.4f,
            Mathf.PerlinNoise(Time.time * 0.08f, 11.7f) - 0.5f) * 3.2f * Time.deltaTime;
        _anchorVel = Vector3.ClampMagnitude(_anchorVel, 1.4f);
        _anchor += _anchorVel * Time.deltaTime;
        _anchor.y = Mathf.Clamp(_anchor.y, GameConfig.SeaFloorY + 4f, -4f);

        // Убегание от белька / любопытство на лай
        bool flee = distToSeal < fleeRadius && _attractTimer <= 0f;

        float dt = Time.deltaTime;
        for (int i = 0; i < fishCount; i++)
        {
            Vector3 pos = _matrices[i].GetColumn(3);
            Vector3 steer = (_anchor - pos) * 0.4f;
            Vector3 vel = _velocities[i];

            if (flee && (pos - sealPos).sqrMagnitude < fleeRadius * fleeRadius)
            {
                steer = (pos - sealPos).normalized * swimSpeed * 2.6f;
            }
            else if (_attractTimer > 0f && distToSeal < GameConfig.BarkAttractRadius + 8f)
            {
                steer = (sealPos - pos).normalized * swimSpeed * 0.8f; // любопытство — к беде
            }

            vel = Vector3.Lerp(vel, steer.normalized * swimSpeed + steer * 0.2f, dt * 1.6f);
            vel += Random.insideUnitSphere * dt * 0.5f;
            if (vel.sqrMagnitude > swimSpeed * swimSpeed * 4f) vel = vel.normalized * swimSpeed * 2f;
            if (vel.sqrMagnitude < 0.05f) vel = Random.onUnitSphere * swimSpeed * 0.5f;

            pos += vel * dt;
            pos.y = Mathf.Clamp(pos.y, GameConfig.SeaFloorY + 2f, -1.6f);

            Quaternion rot = Quaternion.LookRotation(vel.normalized, Vector3.up);
            float wob = Mathf.Sin(Time.time * _wobble[i].y + _wobble[i].x) * 8f;
            rot *= Quaternion.Euler(0, wob, 0);
            _matrices[i] = Matrix4x4.TRS(pos, rot, Vector3.one);

            // Съедание: рыба прямо у рта белька
            if (_seal != null && (pos - sealPos).sqrMagnitude < 1.4f && _seal.Underwater)
            {
                _seal.TryEat(FoodType.Fish);
                pos = _anchor + RandomInSphere(new System.Random(i + (int)Time.time), schoolRadius);
                pos.y = Mathf.Clamp(pos.y, -24f, -4f);
                _matrices[i] = Matrix4x4.TRS(pos, rot, Vector3.one);
            }
        }
        _matrixDirty = true;
    }

    private void LateUpdate()
    {
        if (!_matrixDirty || _mesh == null || _mat == null) return;
        _matrixDirty = false;
        for (int start = 0; start < fishCount; start += BatchSize)
        {
            int count = Mathf.Min(BatchSize, fishCount - start);
            if (_renderBatch == null || _renderBatch.Length < count)
                _renderBatch = new Matrix4x4[BatchSize];
            for (int i = 0; i < count; i++) _renderBatch[i] = _matrices[start + i];
            Graphics.DrawMeshInstanced(_mesh, 0, _mat, _renderBatch, count,
                null, UnityEngine.Rendering.ShadowCastingMode.Off, false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0.5f, 0.98f, 0.9f);
        Gizmos.DrawWireSphere(Application.isPlaying ? _anchor : transform.position, schoolRadius);
    }
}
