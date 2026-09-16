using System;
using UnityEngine;

namespace Whitecoat.World
{
    /// <summary>Перечень реалмов Большого Мира (см. DesignDocs/01).</summary>
    public enum RealmId
    {
        OpenSea = 0,     // Открытое Море (процедурное) — базовая зона сцены
        WarmCove = 1,    // Тёплая Бухта (хаб)
        IceGardens = 2,  // Ледяные Сады (коралловый риф)
    }

    /// <summary>
    /// Реестр реалмов в пределах одной сцены: зоны размещены на дальних offsets,
    /// портал телепортирует Белека между ними. Менеджер отслеживает текущий
    /// реалм и поднимает событие (HUD, квесты, музыка).
    /// Размещение детерминировано HubRealmBuilder'ом.
    /// </summary>
    public class RealmManager : MonoBehaviour
    {
        public static RealmManager Instance { get; private set; }

        [Serializable]
        public class RealmEntry
        {
            public RealmId id;
            public string titleKey;       // ключ локализации
            public Vector3 spawnPoint;    // точка появления Белека
            public Transform focus;       // опорная точка (маяк/раковина) — для HUD-компаса
        }

        [SerializeField] public RealmEntry[] realms;
        [SerializeField] private RealmId current = RealmId.OpenSea;

        public event Action<RealmId> OnRealmChanged;

        public RealmId Current => current;

        private void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(gameObject); return; }
            Instance = this;
        }

        private void OnDestroy() { if (Instance == this) Instance = null; }

        public RealmEntry Get(RealmId id)
        {
            if (realms == null) return null;
            foreach (var r in realms) if (r.id == id) return r;
            return null;
        }

        /// <summary>Телепорт Белека в реалм (мягкий, без загрузки сцены).</summary>
        public bool TravelTo(RealmId id, Transform seal)
        {
            var entry = Get(id);
            if (entry == null || seal == null) return false;

            seal.transform.position = entry.spawnPoint;
            seal.transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.up);

            var rb = seal.GetComponent<Rigidbody>();
            if (rb != null) rb.linearVelocity = Vector3.zero; // Unity 6: linearVelocity
            current = id;
            OnRealmChanged?.Invoke(id);
            Debug.Log($"[RealmManager] Travel -> {id} at {entry.spawnPoint}");
            return true;
        }

        /// <summary>
        /// Установка текущего реалма БЕЗ телепорта (для спавна):
        /// игрок стартует в хабе, но поле current по умолчанию OpenSea.
        /// Вызывается билдером сцены; без события (никто ещё не подписан).
        /// </summary>
        public void SetCurrentSilently(RealmId id) => current = id;

        public Vector3 CurrentSpawn() => Get(current)?.spawnPoint ?? Vector3.zero;
    }
}
