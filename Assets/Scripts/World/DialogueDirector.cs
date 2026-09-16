using System;
using System.Collections.Generic;
using UnityEngine;

namespace Whitecoat.World
{
    /// <summary>
    /// Реплика диалога: текст + опциональный озвучечный клип (Silero, v0.5.0).
    /// Ключ локализации — единый идентификатор текста и клипа.
    /// </summary>
    [Serializable]
    public class DialogueLine
    {
        public string npcId;      // VoiceCast-ключ (DesignDocs/02 §7)
        public string locKey;     // Data/Loc/strings.csv: "npc.bip7.line01"
        public string text;       // fallback-текст (до подключения LocalizationManager)
        public AudioClip voice;   // может быть null (тихие персонажи)
        public float holdSeconds; // сколько показывать субтитры после озвучки
    }

    /// <summary>
    /// Режиссёр диалогов (v0.5.0): субтитры в HUD + озвучка + мягкая пауза мира.
    /// Очередь реплик, отсутствие повторов, события для HUD.
    /// Пока HUD-метод не подключён — реплики идут в лог (v0.4.0 поведение NpcFriend сохранено).
    /// </summary>
    public class DialogueDirector : MonoBehaviour
    {
        public static DialogueDirector Instance { get; private set; }

        [SerializeField] private AudioSource voiceSource; // 2D — диалоги не позиционируем

        private readonly Queue<DialogueLine> _queue = new Queue<DialogueLine>();
        private DialogueLine _current;
        private float _holdUntil;
        private float _worldScaleBackup = 1f;

        public event Action<DialogueLine> OnLineStart;
        public event Action OnLineEnd;

        public bool Busy => _current != null;

        private void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(gameObject); return; }
            Instance = this;
            if (voiceSource == null)
            {
                voiceSource = gameObject.AddComponent<AudioSource>();
                voiceSource.playOnAwake = false;
                voiceSource.spatialBlend = 0f; // 2D
            }
        }

        private void OnDestroy() { if (Instance == this) Instance = null; }

        public void Say(DialogueLine line)
        {
            if (line == null) return;
            if (Busy) { _queue.Enqueue(line); return; }
            Play(line);
        }

        public void SayMany(IEnumerable<DialogueLine> lines)
        {
            foreach (var l in lines)
            {
                if (Busy) _queue.Enqueue(l);
                else Play(l);
            }
        }

        private void Play(DialogueLine line)
        {
            _current = line;
            float dur = 2.2f;
            if (line.voice != null)
            {
                voiceSource.clip = line.voice;
                voiceSource.Play();
                dur = line.voice.length;
            }
            _holdUntil = Time.time + dur + Mathf.Max(0.35f, line.holdSeconds);
            OnLineStart?.Invoke(line);
            Debug.Log($"[Dialogue] {line.npcId}: {line.text}");
        }

        private void Update()
        {
            if (_current == null) return;
            if (Time.time < _holdUntil) return;

            // Конец реплики
            if (voiceSource != null && voiceSource.isPlaying) return; // не перебиваем голос
            OnLineEnd?.Invoke();
            _current = null;

            if (_queue.Count > 0) Play(_queue.Dequeue());
        }
    }
}
