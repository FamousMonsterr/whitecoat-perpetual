using System;
using UnityEngine;

namespace Whitecoat.World
{
    /// <summary>
    /// НПС-друг: автодиалог по близости (ни одной кнопки — доступно 5 годам),
    /// реплика-вариации (никогда подряд одинаковые), событие для HUD-субтитров.
    /// TTS-озвучка подключается в v0.5.0 (ключ VoiceCast — DesignDocs/02).
    /// </summary>
    public class NpcFriend : MonoBehaviour
    {
        [SerializeField] private string npcId = "bip7";
        [SerializeField] private string[] lines = { "БИП! Данные собраны!" };
        [SerializeField] private float talkRadius = 4.5f;
        [SerializeField] private float repeatCooldown = 9f;
        [SerializeField] private Transform lookTarget; // голова НПС — куда смотреть камере (опц.)

        private int _lastLine = -1;
        private float _lastTalk = -99f;
        private Transform _seal;
        private static Transform _sealCache;

        public event Action<string, string> OnSpoke; // (npcId, line)

        /// <summary>Настройка из билдера (Editor): id + набор реплик.</summary>
        public void Configure(string id, string[] dialogueLines)
        {
            npcId = id;
            lines = dialogueLines;
        }

        public string NpcId => npcId;
        public Transform LookTarget => lookTarget != null ? lookTarget : transform;

        private void Update()
        {
            if (Time.time - _lastTalk < repeatCooldown) return;

            if (_seal == null)
            {
                if (_sealCache == null)
                {
                    var sc = FindObjectOfType<SealController>();
                    if (sc == null) return;
                    _sealCache = sc.transform;
                }
                _seal = _sealCache;
            }

            if ((_seal.position - transform.position).sqrMagnitude > talkRadius * talkRadius) return;

            SayNext();
            _lastTalk = Time.time;
        }

        private void SayNext()
        {
            if (lines == null || lines.Length == 0) return;
            int idx;
            if (lines.Length == 1) idx = 0;
            else
            {
                do { idx = UnityEngine.Random.Range(0, lines.Length); }
                while (idx == _lastLine);
            }
            _lastLine = idx;
            OnSpoke?.Invoke(npcId, lines[idx]);
            Debug.Log($"[NpcFriend] {npcId}: {lines[idx]}");
        }
    }
}
