using UnityEngine;
using System.Collections.Generic;

public class ProceduralChunkGenerator : MonoBehaviour
{
    [System.Serializable]
    public struct SpawnRule {
        public GameObject prefab;
        public float density;
        public float minHeight, maxHeight;
        public string noiseType;
    }
    public List<SpawnRule> rules = new();
    public int chunkSize = 32;
    public float noiseScale = 0.15f;
    public float spawnRadius = 80f;
    public Transform player;

    private Dictionary<Vector2Int, bool> loadedChunks = new();
    private Queue<GameObject> pool = new();
    private int maxPoolSize = 150;

    void Start() {
        for (int i = 0; i < maxPoolSize; i++) {
            var go = new GameObject("PooledInstance");
            go.SetActive(false);
            pool.Enqueue(go);
        }
        GenerateAroundPlayer();
    }

    void Update() {
        if (player != null && Vector3.Distance(player.position, transform.position) > chunkSize * 0.8f)
            GenerateAroundPlayer();
    }

    void GenerateAroundPlayer() {
        if (player == null) return;
        transform.position = new Vector3(player.position.x, 0, player.position.z);
        int start = Mathf.FloorToInt(-spawnRadius / chunkSize);
        int end = Mathf.CeilToInt(spawnRadius / chunkSize);

        for (int x = start; x <= end; x++) {
            for (int z = start; z <= end; z++) {
                Vector2Int chunkCoord = new Vector2Int(
                    Mathf.FloorToInt(transform.position.x / chunkSize) + x,
                    Mathf.FloorToInt(transform.position.z / chunkSize) + z
                );
                if (!loadedChunks.ContainsKey(chunkCoord)) {
                    GenerateChunk(chunkCoord);
                    loadedChunks.Add(chunkCoord, true);
                }
            }
        }
    }

    void GenerateChunk(Vector2Int coord) {
        float worldX = coord.x * chunkSize;
        float worldZ = coord.y * chunkSize;

        foreach (var rule in rules) {
            int count = Mathf.RoundToInt(rule.density * (chunkSize * 0.15f));
            for (int i = 0; i < count; i++) {
                float nx = Random.Range(0, chunkSize);
                float nz = Random.Range(0, chunkSize);
                float n = Mathf.PerlinNoise(
                    (worldX + nx) * noiseScale, 
                    (worldZ + nz) * noiseScale
                );
                
                if (n > 0.45f && n < rule.density) {
                    float y = Random.Range(rule.minHeight, rule.maxHeight);
                    Vector3 pos = new Vector3(worldX + nx, y, worldZ + nz);
                    
                    GameObject obj = pool.Count > 0 ? pool.Dequeue() : Instantiate(rule.prefab);
                    obj.transform.position = pos;
                    obj.transform.rotation = Quaternion.Euler(Random.Range(0,360), Random.Range(0,360), Random.Range(0,360));
                    obj.SetActive(true);
                }
            }
        }
    }
}
