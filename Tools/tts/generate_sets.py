#!/usr/bin/env python3.13
"""Догенерация реплик БИП-7 по квестовым наборам (intro/gems/traveler/shell)."""
import os, wave
import torch

MODEL_PATH = "/home/z/my-project/tts/v4_ru.pt"
OUT = "Assets/Audio/Voices"
SR = 24000

SETS = {
    "bip7_line": [
        "БИП! Добро пожаловать домой, Белёк!",
        "Данные собраны: жемчуг светится ярче твоей улыбки!",
        "За восточной аркой шумит риф. Проверим?",
        "Маяк стал ярче. Мои сенсоры довольны!",
    ],
    "bip7_gems": [
        "БИП-отлично! Десять жемчужин уже в копилке!",
        "За восточной аркой шумит риф. Проверим?",
        "Волна к волне — и мы в Ледяных Садах!",
    ],
    "bip7_trav": [
        "Ты вернулся домой путешественником. Данные обновлены!",
        "Раковине нужно пятьдесят жемчужин, чтобы запеть. Дорога длинная, плыви спокойно!",
    ],
    "bip7_shell": [
        "Раковина поёт! Мои микрофоны счастливые!",
        "Маяк стал ярче. Мои сенсоры довольны!",
        "БИП! Морю стало веселее, когда его друг вернулся домой.",
    ],
    "marta_line": [
        "Эх, море, море. Маяки погасли, малыш. Поможешь старой черепахе?",
    ],
    "ded_priboy_line": [
        "Слушай прибой, дитя. Он всегда приводит домой.",
    ],
    "fyrka_line": [
        "Я быстрее всех на всём льду! Ну, почти всех. Ладно, гонка?",
    ],
    "tsypa_line": [
        "Ай-ай-ай! Всё пропало! Хотя нет, кажется, не всё.",
    ],
    "khranitel_line": [
        "Кто тревожит камень?",
    ],
}
SPEAKER = "baya"  # у БИП-7 один голос во всех наборах; остальные — по своим ключам
SR_SPEAKERS = {p: SPEAKER for p in SETS}

def write_wav16(path, audio, sr):
    a = audio.detach().cpu().clamp(-1, 1)
    pcm = (a * 32767.0).to(torch.int16).numpy().tobytes()
    with wave.open(path, "wb") as w:
        w.setnchannels(1); w.setsampwidth(2); w.setframerate(sr); w.writeframes(pcm)

def main():
    imp = torch.package.PackageImporter(MODEL_PATH)
    model = imp.load_pickle("tts_models", "model")
    os.makedirs(OUT, exist_ok=True)
    for prefix, lines in SETS.items():
        speaker = SR_SPEAKERS[prefix]
        for i, text in enumerate(lines, 1):
            audio = model.apply_tts(text=text, speaker=speaker, sample_rate=SR,
                                    put_accent=True, put_yo=True)
            out = os.path.join(OUT, f"{prefix}{i:02d}.wav")
            write_wav16(out, audio, SR)
            print(f"OK {out} ({os.path.getsize(out)/1024:.0f} KB)")

if __name__ == "__main__":
    main()
