#!/usr/bin/env python3.13
"""Silero TTS генерация голосов персонажей «Белёк» (v0.5.0 пайплайн).
Контракт голосов — DesignDocs/02 §7 (VoiceCast). Модель НЕ попадает в игру:
в Assets/Audio/Voices/ идут только готовые WAV.
Запуск: python3.13 Tools/tts/generate.py            (из корня репо)
"""
import os, sys, wave
import torch

MODEL_PATH = os.environ.get("SILERO_MODEL", "/home/z/my-project/tts/v4_ru.pt")
OUT_DIR = sys.argv[1] if len(sys.argv) > 1 else "Assets/Audio/Voices"
SR = 24000

# VoiceCast: персонаж → (спикер v4_ru [aidar|baya|kseniya|xenia|eugene], speech_rate)
VOICECAST = {
    "marta":      ("aidar",  0.85),   # старая черепаха, тёплый низкий
    "bip7":       ("baya",   1.05),   # робот-энтузиаст, радостный
    "ded_priboy": ("kseniya",0.90),   # голос маяка, мягкий
    "fyrka":      ("eugene", 1.10),   # песец-хвастунишка
    "tsypa":      ("xenia",  1.08),   # чайка-паникёрша
    "khranitel":  ("aidar",  0.60),   # голем: медленный гул
}

# Первые реплики (id → текст). Позже читает dialogues.csv.
LINES = {
    ("bip7", "line01"): "БИП! Добро пожаловать домой, Белёк!",
    ("bip7", "line02"): "Данные собраны: жемчуг светится ярче твоей улыбки!",
    ("bip7", "line03"): "За восточной аркой шумит риф. Проверим?",
    ("bip7", "line04"): "Маяк стал ярче. Мои сенсоры довольны!",
    ("marta", "line01"): "Эх, море, море. Маяки погасли, малыш. Поможешь старой черепахе?",
    ("ded_priboy", "line01"): "Слушай прибой, дитя. Он всегда приводит домой.",
    ("fyrka", "line01"): "Я быстрее всех на всём льду! Ну, почти всех. Ладно, гонка?",
    ("tsypa", "line01"): "Ай-ай-ай! Всё пропало! Хотя нет, кажется, не всё.",
    ("khranitel", "line01"): "Кто тревожит камень?",
}


def write_wav16(path, audio: torch.Tensor, sr: int):
    """int16 PCM WAV (моно) — Unity импортирует нативно."""
    import struct
    a = audio.detach().cpu().clamp(-1, 1)
    pcm = (a * 32767.0).to(torch.int16).numpy().tobytes()
    with wave.open(path, "wb") as w:
        w.setnchannels(1)
        w.setsampwidth(2)
        w.setframerate(sr)
        w.writeframes(pcm)


def main():
    device = torch.device("cpu")
    imp = torch.package.PackageImporter(MODEL_PATH)
    model = imp.load_pickle("tts_models", "model")
    model.to(device)
    os.makedirs(OUT_DIR, exist_ok=True)
    print("speakers:", model.speakers)

    for (npc, key), text in LINES.items():
        speaker, rate = VOICECAST[npc]
        try:
            audio = model.apply_tts(
                text=text, speaker=speaker, sample_rate=SR,
                put_accent=True, put_yo=True,
            )
        except Exception as e:
            print(f"FAIL {npc}/{key}: {e}")
            continue

        # Темп речи: линейная интерполяция по времени
        if abs(rate - 1.0) > 0.01:
            n = int(audio.numel() / rate)
            audio = torch.nn.functional.interpolate(
                audio.unsqueeze(0).unsqueeze(0).float(), size=n, mode="linear"
            ).squeeze().clamp(-1, 1)

        out = os.path.join(OUT_DIR, f"{npc}_{key}.wav")
        write_wav16(out, audio, SR)
        dur = audio.numel() / SR
        print(f"OK {out} ({os.path.getsize(out)/1024:.0f} KB, {dur:.1f}s)")

if __name__ == "__main__":
    main()
