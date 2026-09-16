using System;
using UnityEngine;

namespace Whitecoat.World
{
    /// <summary>
    /// Счётчик жемчуга: серии сбора (комбо-звон), totals, сохранение через
    /// SaveSystem. Единая точка правды для HUD, квестов и маяков-реакций.
    /// </summary>
    public class PearlLedger : MonoBehaviour
    {
        public static PearlLedger Instance { get; private set; }

        [Header("Текущее состояние")]
        [SerializeField] private int total;
        [SerializeField] private int streak;
        [SerializeField] private float lastCollectTime;

        /// <summary>Серия: окно между сборами, после которого комбо сбрасывается.</summary>
        private const float StreakWindow = 4f;
        private const int MaxStreak = 12;

        public int Total => total;
        public int Streak => streak;

        public event Action<int, int> OnCollected;   // (total, streak)
        public event Action OnStreakBroken;

        [Serializable]
        public class SaveData { public int total; }

        private void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(gameObject); return; }
            Instance = this;
            Load();
        }

        private void OnDestroy() { if (Instance == this) Instance = null; }

        private void Update()
        {
            if (streak > 0 && Time.time - lastCollectTime > StreakWindow)
            {
                streak = 0;
                OnStreakBroken?.Invoke();
            }
        }

        public void Collect(int value, Vector3 at)
        {
            if (Time.time - lastCollectTime <= StreakWindow) streak = Mathf.Min(streak + 1, MaxStreak);
            else streak = 1;
            lastCollectTime = Time.time;

            total += Mathf.Max(1, value);
            OnCollected?.Invoke(total, streak);
            Debug.Log($"[PearlLedger] +{value} at {at} (total={total}, streak={streak})");
            Save();
        }

        // --- Сохранение (совместимо с SaveSystem-подходом: PlayerPrefs-safe json) ---
        private const string Key = "wc_pearls_v1";

        public void Save()
        {
            try
            {
                var json = JsonUtility.ToJson(new SaveData { total = total });
                System.IO.File.WriteAllText(System.IO.Path.Combine(applicationDataPath(), Key), json);
            }
            catch (Exception e) { Debug.LogWarning($"[PearlLedger] save failed: {e.Message}"); }
        }

        private void Load()
        {
            try
            {
                var path = System.IO.Path.Combine(applicationDataPath(), Key);
                if (!System.IO.File.Exists(path)) return;
                var data = JsonUtility.FromJson<SaveData>(System.IO.File.ReadAllText(path));
                total = Mathf.Max(0, data.total);
            }
            catch (Exception e) { Debug.LogWarning($"[PearlLedger] load failed: {e.Message}"); }
        }

        private static string applicationDataPath()
        {
            // persistentDataPath безопасен на Win/macOS и в batchmode
            return Application.persistentDataPath;
        }
    }
}
