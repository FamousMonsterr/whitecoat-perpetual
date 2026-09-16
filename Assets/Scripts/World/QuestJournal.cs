using System;
using System.Collections.Generic;
using UnityEngine;

namespace Whitecoat.World
{
    /// <summary>
    /// Квест-журнал (v0.5.0): сюжетная цепочка + побочные (DesignDocs/02 §5).
    /// Тиры 5/7/10 определяют ТОЛЬКО подсветку и подсказки, не доступность.
    /// Данные квестов — через QuestDefinition (ScriptableObject-friendly),
    /// состояние хранится в PlayerPrefs-файле (как PearlLedger).
    /// </summary>
    public class QuestJournal : MonoBehaviour
    {
        public static QuestJournal Instance { get; private set; }

        [Serializable]
        public class QuestState
        {
            public string id;
            public int stage;        // 0 = не начат; 1..N = шаги; 99 = завершён
            public bool completed;
        }

        [Serializable]
        public class QuestSave { public List<QuestState> quests = new List<QuestState>(); }

        private readonly Dictionary<string, QuestState> _quests = new Dictionary<string, QuestState>();

        public event Action<string, int> OnQuestStage;      // (questId, newStage)
        public event Action<string> OnQuestCompleted;

        private void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(gameObject); return; }
            Instance = this;
            Load();
        }

        private void OnDestroy() { if (Instance == this) Instance = null; }

        public QuestState Get(string id) =>
            _quests.TryGetValue(id, out var s) ? s : null;

        public bool IsCompleted(string id) => Get(id)?.completed ?? false;

        /// <summary>Перевод квеста на следующую стадию (или создание со stage).</summary>
        public void Advance(string questId, int toStage)
        {
            if (!_quests.TryGetValue(questId, out var s))
            {
                s = new QuestState { id = questId, stage = toStage };
                _quests[questId] = s;
            }
            else if (s.completed) return; // завершённые не трогаем
            else s.stage = toStage;

            OnQuestStage?.Invoke(questId, s.stage);
            Debug.Log($"[QuestJournal] {questId} -> stage {s.stage}");
            Save();
        }

        public void Complete(string questId)
        {
            if (!_quests.TryGetValue(questId, out var s))
                _quests[questId] = s = new QuestState { id = questId };
            if (s.completed) return;
            s.completed = true;
            s.stage = 99;
            OnQuestCompleted?.Invoke(questId);
            Debug.Log($"[QuestJournal] {questId} COMPLETED");
            Save();
        }

        // --- Сохранение ---
        private const string Key = "wc_quests_v1";

        public void Save()
        {
            try
            {
                var data = new QuestSave { quests = new List<QuestState>(_quests.Values) };
                var json = JsonUtility.ToJson(data);
                System.IO.File.WriteAllText(System.IO.Path.Combine(Application.persistentDataPath, Key), json);
            }
            catch (Exception e) { Debug.LogWarning($"[QuestJournal] save: {e.Message}"); }
        }

        private void Load()
        {
            try
            {
                var path = System.IO.Path.Combine(Application.persistentDataPath, Key);
                if (!System.IO.File.Exists(path)) return;
                var data = JsonUtility.FromJson<QuestSave>(System.IO.File.ReadAllText(path));
                _quests.Clear();
                foreach (var q in data.quests) _quests[q.id] = q;
            }
            catch (Exception e) { Debug.LogWarning($"[QuestJournal] load: {e.Message}"); }
        }
    }
}
