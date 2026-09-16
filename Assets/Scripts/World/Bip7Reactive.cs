using System;
using UnityEngine;
using Whitecoat.World;

/// <summary>
/// БИП-7 реагирует на прогресс квестов: набор реплик (с озвучкой) меняется по
/// состоянию журнала. Мир «помнит» достижения ребёнка — ключ удержания.
/// VoiceSet'ы (реплики + Silero-клипы) назначает билдер сцены.
/// </summary>
public class Bip7Reactive : MonoBehaviour
{
    [Serializable]
    public class VoiceSet
    {
        public string[] lines;
        public AudioClip[] clips;
    }

    [SerializeField] private NpcFriend npc;
    [SerializeField] private VoiceSet intro;
    [SerializeField] private VoiceSet afterGems;
    [SerializeField] private VoiceSet afterTraveler;
    [SerializeField] private VoiceSet afterShell;

    private void Start()
    {
        if (npc == null) npc = GetComponent<NpcFriend>();
        if (QuestJournal.Instance != null)
        {
            QuestJournal.Instance.OnQuestCompleted += _ => Refresh();
            QuestJournal.Instance.OnQuestStage += (id, s) => Refresh();
        }
        Refresh();
    }

    private void Refresh()
    {
        if (npc == null || QuestJournal.Instance == null) return;
        var q = QuestJournal.Instance;

        VoiceSet set =
            q.IsCompleted("q.singing_shell") ? afterShell :
            q.IsCompleted("q.traveler") ? afterTraveler :
            q.IsCompleted("q.first_gems") ? afterGems :
            intro;

        if (set == null || set.lines == null || set.lines.Length == 0) return;
        npc.SetLines(set.lines, set.clips);
    }
}
