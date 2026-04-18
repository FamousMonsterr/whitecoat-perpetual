# 🐾 Белёк: Вечный Прибой (Whitecoat: Perpetual Tide)

3D-симулятор выживания и эволюции ластоногих. Цикл поколений, генетическое наследование, динамическая погода и кинематографичный геймплей.

> **Обновлено для Unity 6 (6000.4)** с использованием новейших функций рендеринга, оптимизации и сборки.

[![Build Status](https://github.com/FamousMonsterr/whitecoat-perpetual/actions/workflows/build.yml/badge.svg)](https://github.com/FamousMonsterr/whitecoat-perpetual/actions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![Unity](https://img.shields.io/badge/Unity-6000.4%20(6%20Tech)-blue.svg)](https://unity.com)
[![Languages](https://img.shields.io/badge/Langs-RU%20%7C%20EN%20%7C%20DE-green.svg)](Assets/Data/Loc/strings.csv)

## 🌊 Особенности

- 🧬 **Генетика:** Бонусы глубины, дыхания и терморегуляции передаются между поколениями
- 🌪 **Погода:** Штормы, Blizzard, волны и видимость влияют на геймплей и ИИ хищников
- 🐋 **Адаптивный ИИ:** Касатка меняет тактику от патрулирования до засад
- 📷 **Кинематографичная камера:** Cinemachine с подводной физикой и динамикой FOV
- 🎵 **Адаптивный звук:** FMOD/Unity Audio Mixer реагирует на глубину и угрозу
- 🌍 **Процедурный мир:** Чанки льда, рифов и водорослей генерируются вокруг игрока
- 💡 **URP + Render Graph:** Биолюминесценция и продвинутые эффекты освещения в Unity 6
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

Для автоматической сборки используйте команду (путь может отличаться в зависимости от версии):

```powershell
& "C:\Program Files\Unity\Hub\Editor\6000.4.0f1\Editor\Unity.exe" -quit -batchmode -projectPath . -executeMethod BuildScript.PerformBuild -logFile build.log
```

## 📦 CI/CD

Проект настроен для автоматической сборки через **GitHub Actions** с использованием **Unity 6 Tech**.

При пуше в ветку `main`:
1. Запускается контейнер с Unity 6 (6000.4.0f1).
2. Собирается `.exe` версия с поддержкой IL2CPP.
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

© 2024-2025 Whitecoat Game Studio. Built with Unity 6 Tech.