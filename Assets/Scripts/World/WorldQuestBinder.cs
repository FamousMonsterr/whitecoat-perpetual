using UnityEngine;
using Whitecoat.World;

/// <summary>
/// Привязка мира к квестам v0.4.1 (сюжет DesignDocs/02 §5, упрощённо):
///   q.first_gems      «Первый блеск»        — собрать 10 жемчужин;
///   q.traveler        «Путешественник»      — побывать в Ледяных Садах и вернуться в хаб;
///   q.singing_shell   «Поющая Раковина»     — собрать 50 жемчужин (цель реалма 1).
/// Компонент вешается билдером на RealmSystems. Слушает события, никаких Update.
/// </summary>
public class WorldQuestBinder : MonoBehaviour
{
    [Header("Пороги (жемчуг)")]
    [SerializeField] private int firstGemsGoal = 10;
    [SerializeField] private int singingShellGoal = 50;

    private bool _visitedGardens;
    private bool _visitedCoveAfterGardens;

    private void Start()
    {
        if (PearlLedger.Instance != null)
            PearlLedger.Instance.OnCollected += HandlePearls;
        if (RealmManager.Instance != null)
            RealmManager.Instance.OnRealmChanged += HandleRealm;

        // Восстановление прогресса после загрузки сейва
        var q = QuestJournal.Instance;
        if (q == null) return;
        if (PearlLedger.Instance != null) HandlePearls(PearlLedger.Instance.Total, 0);
    }

    private void OnDestroy()
    {
        if (PearlLedger.Instance != null) PearlLedger.Instance.OnCollected -= HandlePearls;
        if (RealmManager.Instance != null) RealmManager.Instance.OnRealmChanged -= HandleRealm;
    }

    private void HandlePearls(int total, int streak)
    {
        var q = QuestJournal.Instance;
        if (q == null) return;

        if (total >= firstGemsGoal && !q.IsCompleted("q.first_gems"))
        {
            q.Complete("q.first_gems");
            LogQuest("Первый блеск — выполнено! БИП-7 гордится тобой.");
        }

        if (total >= singingShellGoal && !q.IsCompleted("q.singing_shell"))
        {
            q.Complete("q.singing_shell");
            LogQuest("Поющая Раковина напилась жемчужного света и поёт!");
        }
    }

    private void HandleRealm(RealmId id)
    {
        var q = QuestJournal.Instance;
        if (q == null) return;

        // «Путешественник»: дойти до Садов и вернуться домой
        if (id == RealmId.IceGardens)
        {
            _visitedGardens = true;
            if (!q.IsCompleted("q.traveler")) q.Advance("q.traveler", 1);
        }
        else if (id == RealmId.WarmCove && _visitedGardens && !q.IsCompleted("q.traveler"))
        {
            _visitedCoveAfterGardens = true;
            q.Complete("q.traveler");
            LogQuest("Путешественник — дом встречает героя!");
        }
    }

    private static void LogQuest(string msg) => Debug.Log($"[WorldQuestBinder] {msg}");
}
