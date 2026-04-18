# 🐾 Белёк: Вечный Прибой (Whitecoat: Perpetual Tide)

3D-симулятор выживания и эволюции ластоногих. Цикл поколений, генетическое наследование, динамическая погода и кинематографичный геймплей.

[![Build Status](https://github.com/FamousMonsterr/whitecoat-perpetual/actions/workflows/build.yml/badge.svg)](https://github.com/FamousMonsterr/whitecoat-perpetual/actions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![Unity](https://img.shields.io/badge/Unity-2022.3%20LTS-blue.svg)](https://unity.com)

## 🌊 Особенности

- 🧬 **Генетика:** Бонусы глубины, дыхания и терморегуляции передаются между поколениями
- 🌪 **Погода:** Штормы, Blizzard, волны и видимость влияют на геймплей и ИИ хищников
- 🐋 **Адаптивный ИИ:** Касатка меняет тактику от патрулирования до засад
- 📷 **Кинематографичная камера:** Cinemachine с подводной физикой и динамикой FOV
- 🎵 **Адаптивный звук:** FMOD/Unity Audio Mixer реагирует на глубину и угрозу
- 🌍 **Процедурный мир:** Чанки льда, рифов и водорослей генерируются вокруг игрока
- 🌐 **Локализация:** RU / EN / DE (CSV, авто-детект системы)
- 📊 **Аналитика:** Unity Services + Crash Reporting
- 🎮 **Steamworks:** Поддержка ачивок и статистики (требуется AppID)

## 🛠 Сборка (Local Build)

### Требования

- Unity Hub & **Unity 2022.3.15f1 LTS**
- Модуль: `Windows Build Support (IL2CPP)`
- Пакеты (Package Manager):
  - Universal RP
  - Cinemachine
  - Input System
  - TextMeshPro
  - Unity Services (Analytics)
  - Facepunch Steamworks (опционально)

### Шаги

1. Клонируйте репозиторий:
   ```bash
   git clone https://github.com/FamousMonsterr/whitecoat-perpetual.git
   cd whitecoat-perpetual
   ```

2. Откройте проект в Unity Hub.

3. Дождитесь импорта ассетов.

4. Перейдите в `File > Build Settings`.

5. Выберите платформу `Windows, Mac, Linux Standalone` -> `Windows 64-bit`.

6. Нажмите `Build` и выберите папку `Builds/Windows`.

### CLI Сборка (Command Line)

```powershell
& "C:\Program Files\Unity\Hub\Editor\2022.3.15f1\Editor\Unity.exe" -quit -batchmode -projectPath . -executeMethod BuildScript.PerformBuild -logFile build.log
```

## 📦 CI/CD

Проект настроен для автоматической сборки через **GitHub Actions**.

При пуше в ветку `main`:
1. Запускается контейнер с Unity.
2. Собирается `.exe` версия.
3. Артефакт доступен во вкладке **Actions > Artifacts**.

*Резервный канал:* Unity Cloud Build (настройки в `ProjectSettings/CloudBuildSettings.json`).

## 📰 Пресс-кит

Материалы для прессы находятся в папке `Assets/PressKit/`:
- Факт-лист (`FactSheet.md`)
- Сценарий трейлера (`TrailerScript.md`)
- Логотипы и скриншоты

Контакты: `dev@whitecoat.game` | Discord: `discord.gg/whitecoat`

## 📜 Лицензия

- Код: **MIT**
- Ассеты (модели/текстуры): **CC0** (Kenney, Poly Haven)
- Шейдеры и системы управления: Собственная разработка.

---

© 2024 Whitecoat Game Studio. All rights reserved.