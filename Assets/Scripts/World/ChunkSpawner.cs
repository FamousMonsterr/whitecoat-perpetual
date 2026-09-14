using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Процедурный мир: чанки 48м вокруг игрока, детерминированные по сиду моря.
/// Лёд кольцами (арктический архипелаг), рифы и водоросли пятнами шума,
/// криль-облака в толще воды. Пул НА КАЖДЫЙ префаб, выгрузка чанков.
/// </summary>
public class ChunkSpawner : MonoBehaviour
{
    [System.Serializable]
    public struct SpawnRule
    {
        public GameObject prefab;
        [Range(0f, 1f)] public float density;      // средняя плотность в чанке
        public float yMin, yMax;
        public float scaleMin, scaleMax;
        public bool alignToWater;                   // льды: верх на уровне воды
        [Range(0f, 1f)] public float noiseBandMin;  // окно шума, где спавнится
        [Range(0f, 1f)] public float noiseBandMax;
    }

    [Header("Правила спавна (заполняет SceneBuilder)")]
    public SpawnRule[] floes;
    public SpawnRule[] underwater;

    [Header("Ссылки")]
    public Transform player;

    private const int ChunkSize = GameConfig.ChunkSize;
    private readonly Dictionary<Vector2Int, List<GameObject>> _chunks = new Dictionary<Vector2Int, List<GameObject>>(64);
    private readonly Dictionary<GameObject, Queue<GameObject>> _pools = new Dictionary<GameObject, Queue<GameObject>>(16);
    private Vector2Int _lastChunk;
    private static readonly float NoiseScale = 0.055f;

    private void Start()
    {
        if (player == null)
        {
            var seal = SealController.Instance;
            if (seal != null) player = seal.transform;
        }
        _lastChunk = new Vector2Int(int.MinValue, int.MinValue);
        Refresh(true);
    }

    private void Update()
    {
        if (player == null) return;
        Refresh(false);
    }

    private Vector2Int ChunkOf(Vector3 pos) =>
        new(Mathf.FloorToInt(pos.x / ChunkSize), Mathf.FloorToInt(pos.z / ChunkSize));

    private void Refresh(bool immediate)
    {
        Vector2Int center = ChunkOf(player.position);
        if (center == _lastChunk && !immediate) return;
        _lastChunk = center;
        int r = GameConfig.ChunkRadius;

        // Загрузка недостающих
        for (int x = -r; x <= r; x++)
        for (int z = -r; z <= r; z++)
        {
            var coord = new Vector2Int(center.x + x, center.y + z);
            if (!_chunks.ContainsKey(coord))
            {
                _chunks.Add(coord, null);
                StartCoroutine(GenerateChunk(coord));
            }
        }

        // Выгрузка дальних
        List<Vector2Int> toRemove = null;
        foreach (var kv in _chunks)
        {
            if (Mathf.Abs(kv.Key.x - center.x) > r + 1 || Mathf.Abs(kv.Key.y - center.y) > r + 1)
            {
                (toRemove ??= new List<Vector2Int>()).Add(kv.Key);
            }
        }
        if (toRemove != null)
        {
            foreach (var key in toRemove)
            {
                if (_chunks[key] != null)
                    foreach (var go in _chunks[key])
                        Despawn(go);
                _chunks.Remove(key);
            }
        }
    }

    private System.Collections.IEnumerator GenerateChunk(Vector2Int coord)
    {
        var spawned = new List<GameObject>();
        yield return null; // распределение генерации по кадрам

        float worldX = coord.x * ChunkSize;
        float worldZ = coord.y * ChunkSize;

        // Детерминированный rng на чанк
        int hash = SeaRandom.Seed() ^ (coord.x * 73856093) ^ (coord.y * 19349663);
        hash = hash < 0 ? -hash : hash;
        var rng = new System.Random(hash);

        // Дистанция от нуля — открытый океан дальше льда
        float distFromOrigin = new Vector2(worldX + ChunkSize / 2f, worldZ + ChunkSize / 2f).magnitude;

        SpawnFloes(worldX, worldZ, rng, distFromOrigin, spawned);
        SpawnUnderwater(worldX, worldZ, rng, spawned);

        _chunks[coord] = spawned;
    }

    private void SpawnFloes(float worldX, float worldZ, System.Random rng,
        float distFromOrigin, List<GameObject> spawned)
    {
        if (floes == null) return;
        foreach (var rule in floes)
        {
            // Кольца льда: плотность спадает с расстоянием
            float ringFalloff = Mathf.Clamp01(1.2f - distFromOrigin / 220f);
            int count = Mathf.RoundToInt(rule.density * 3f * ringFalloff *
                                        (0.5f + (float)rng.NextDouble()));
            for (int i = 0; i < count; i++)
            {
                float nx = (float)rng.NextDouble() * ChunkSize;
                float nz = (float)rng.NextDouble() * ChunkSize;
                float n = Mathf.PerlinNoise((worldX + nx) * NoiseScale + 31.7f,
                                            (worldZ + nz) * NoiseScale + 11.3f);
                if (n < rule.noiseBandMin || n > rule.noiseBandMax) continue;

                float scale = Mathf.Lerp(rule.scaleMin, rule.scaleMax, (float)rng.NextDouble());
                Vector3 pos = new Vector3(worldX + nx, 0f, worldZ + nz);
                var go = Spawn(rule.prefab, pos, scale, rng);
                if (go != null) spawned.Add(go);
            }
        }
    }

    private void SpawnUnderwater(float worldX, float worldZ, System.Random rng,
        List<GameObject> spawned)
    {
        if (underwater == null) return;
        foreach (var rule in underwater)
        {
            int count = Mathf.RoundToInt(rule.density * 4f * (0.4f + (float)rng.NextDouble()));
            for (int i = 0; i < count; i++)
            {
                float nx = (float)rng.NextDouble() * ChunkSize;
                float nz = (float)rng.NextDouble() * ChunkSize;
                float n = Mathf.PerlinNoise((worldX + nx) * NoiseScale * 1.8f + 77.7f,
                                            (worldZ + nz) * NoiseScale * 1.8f + 55.5f);
                if (n < rule.noiseBandMin || n > rule.noiseBandMax) continue;

                float scale = Mathf.Lerp(rule.scaleMin, rule.scaleMax, (float)rng.NextDouble());
                float y = Mathf.Lerp(rule.yMin, rule.yMax, (float)rng.NextDouble());
                Vector3 pos = new Vector3(worldX + nx, y, worldZ + nz);
                var go = Spawn(rule.prefab, pos, scale, rng);
                if (go != null) spawned.Add(go);
            }
        }
    }

    private GameObject Spawn(GameObject prefab, Vector3 pos, float scale, System.Random rng)
    {
        if (prefab == null) return null;
        if (!_pools.TryGetValue(prefab, out var pool))
        {
            pool = new Queue<GameObject>();
            _pools[prefab] = pool;
        }

        GameObject go;
        if (pool.Count > 0)
        {
            go = pool.Dequeue();
        }
        else
        {
            go = Instantiate(prefab);
            go.transform.SetParent(null);
        }
        go.transform.position = pos;
        go.transform.rotation = Quaternion.Euler(0, (float)rng.NextDouble() * 360f, 0);
        go.transform.localScale = Vector3.one * scale;
        go.SetActive(true);
        return go;
    }

    private void Despawn(GameObject go)
    {
        if (go == null) return;
        go.SetActive(false);
        // Возврат в пул своего префаба — по имени (префаб-источник сохранён при инстансе)
        foreach (var kv in _pools)
        {
            if (kv.Key != null && go.name.StartsWith(kv.Key.name))
            {
                kv.Value.Enqueue(go);
                return;
            }
        }
        Destroy(go);
    }
}
