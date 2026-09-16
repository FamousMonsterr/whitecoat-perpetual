using UnityEngine;
using Whitecoat.World;

/// <summary>
/// БИП-7 реагирует на прогресс квестов: наборы реплик меняются по состоянию
/// журнала. Мир «помнит» достижения ребёнка — ключ удержания (DesignDocs/00 §4).
/// </summary>
public class Bip7Reactive : MonoBehaviour
{
    [SerializeField] private NpcFriend npc;

    private readonly string[] _intro =
    {
        "БИП! Добро пожаловать домой, Белёк!",
        "Данные собраны: жемчуг светится ярче твоей улыбки!",
        "Собери десять жемчужин — и посмотрим, что скажут датчики!",
    };
    private readonly string[] _afterGems =
    {
        "БИП-отлично! Десять жемчужин уже в копилке!",
        "За восточной аркой шумит риф. Проверим?",
        "Волна к волне — и мы в Ледяных Садах!",
    };
    private readonly string[] _afterTraveler =
    {
        "Ты вернулся домой путешественником. Данные обновлены!",
        "Раковине нужно пятьдесят жемчужин, чтобы запеть. Дорога длинная — плыви спокойно!",
    };
    private readonly string[] _afterShell =
    {
        "Раковина поёт! Мои микрофоны счастливые!",
        "Маяк стал ярче. Мои сенсоры довольны!",
        "БИП! Морю стало веселее, когда его друг вернулся домой.",
    };

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

        if (q.IsCompleted("q.singing_shell")) npc.Configure("bip7", _afterShell);
        else if (q.IsCompleted("q.traveler")) npc.Configure("bip7", _afterTraveler);
        else if (q.IsCompleted("q.first_gems")) npc.Configure("bip7", _afterGems);
        else npc.Configure("bip7", _intro);
    }
}
