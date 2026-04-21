# План исправлений CI/CD whitecoat-perpetual (модель Финкинг)

## 1. Проблематика (DEFINE)

На основе полного анализа лога CI/CD (5635 строк) и репозитория выявлены следующие критические проблемы:

### 1.1 Критические ошибки сборки
- **CS1061**: `CinemachineFollow` does not contain `Damping` — несовместимость API Cinemachine 3.x
- **Отсутствие .meta файлов**: 0 meta-файлов в проекте → Unity не может отслеживать GUID, все ссылки будут сломаны при открытии
- **Пустая сцена Main.unity**: 114 строк, 0 GameObjects — сборка создаст пустую игру
- **Фиктивные GUID в GraphicsSettings**: Ссылки на URP ассеты содержат несуществующие GUID (8a7e2b2c3d4e5f6a7b8c9d0e1f2a3b4c)

### 1.2 Отсутствующие компоненты инфраструктуры
- Нет `packages-lock.json` → непредсказуемое разрешение зависимостей, долгая сборка
- Нет `ProjectVersion.txt` → CI не может проверить версию Unity
- Нет `ProjectSettings.asset` → базовые настройки проекта отсутствуют
- Нет `EditorSettings.asset`, `TagManager.asset`, `InputManager.asset`, `QualitySettings.asset`, `TimeManager.asset`, `AudioManager.asset`, `Physics2DSettings.asset`, `DynamicsManager.asset`, `NavMeshAreas.asset`, `NetworkManager.asset`, `ClusterInputManager.asset`, `UnityConnectSettings.asset`

### 1.3 Проблемы workflow
- `Cache not found` — кеш не работает из-за отсутствия Library
- `CreateDirectory '/root/.cache/unity3d' failed` — проблемы с правами в контейнере
- `Native extension for WindowsStandalone target not found` — предупреждения, не критичны
- `Curl error 42: Callback aborted` — сетевая ошибка при загрузке пакетов

### 1.4 Потенциальные runtime проблемы
- `AnalyticsManager` использует `Unity.Services.Analytics` без проверки доступности сервиса в CI
- `LocalizationManager` требует `strings.csv` — файл есть, но может отсутствовать в билде
- `FMODManager` — mock режим, корректен
- `WeatherVisuals` требует `ParticleSystem` ссылки — будут null reference если не назначены
- `ProceduralChunkGenerator` требует `player` Transform — null если не назначен
- `CameraSealController` требует `CinemachineThirdPersonFollow` — null если компонент отсутствует

### 1.5 Конфликтные/устаревшие пакеты
- `com.unity.barracuda` 3.0.0 — deprecated, Unity рекомендует использовать Sentis
- `com.unity.ai.inference` 2.6.1 — может конфликтовать с Barracuda
- `moonsharp` — git зависимость, может отваливаться в CI
- `com.unity.textmeshpro` 3.2.0 — в Unity 6 встроен в `com.unity.ugui`, может дублироваться
- Нет `com.unity.ide.visualstudio` — для работы в IDE

## 2. Анализ причин (ANALYZE)

### Корневая причина ошибки компиляции Cinemachine
В Cinemachine 3.x API полностью переработан:
- `CinemachineVirtualCamera` → `CinemachineCamera`
- `Cinemachine3rdPersonFollow` (устарел) → `CinemachineThirdPersonFollow`
- `BodyDamping` → удалено, заменено на `Damping` в `CinemachineThirdPersonFollow`
- `CinemachineFollow` (новый компонент) использует `TrackerSettings.PositionDamping` вместо прямого `Damping`

Предыдущие исправления заменили `BodyDamping` на `Damping` но не проверили:
1. Наличие компонента `CinemachineThirdPersonFollow` на объекте
2. Корректность получения компонента через `GetComponent` vs `GetComponentInChildren`
3. Соответствие типов (CinemachineFollow vs CinemachineThirdPersonFollow)

### Корневая причина пустой сцены
Сцена Main.unity создана программно без GameObjects. Для работы игры требуются:
- Main Camera (с CinemachineBrain)
- CinemachineCamera (с ThirdPersonFollow)
- Player объект (с Rigidbody, InputHandler)
- WeatherSystem + WeatherVisuals
- Directional Light
- ProceduralChunkGenerator
- UI Canvas (для LocalizationManager)
- FMODManager
- AnalyticsManager

### Корневая причина отсутствия .meta файлов
При создании ассетов через текстовые редакторы/скрипты .meta файлы не были сгенерированы. Unity требует .meta для каждого ассета в проекте.

## 3. План действий (PLAN)

### Фаза A: Инфраструктура проекта (критично)
A1. Сгенерировать .meta файлы для всех ассетов с валидными GUID
A2. Создать `ProjectVersion.txt` с версией Unity 6000.4.0f1
A3. Создать базовые `ProjectSettings/*.asset` файлы
A4. Создать `Packages/packages-lock.json` для фиксации версий
A5. Обновить `manifest.json` — заменить/удалить конфликтные пакеты

### Фаза B: Ассеты и сцены (критично)
B1. Создать корректные URP ассеты с валидными GUID
B2. Обновить `GraphicsSettings.asset` с реальными GUID
B3. Пересоздать `Main.unity` с необходимыми GameObjects:
   - Directional Light
   - Main Camera + CinemachineBrain
   - CinemachineCamera + CinemachineThirdPersonFollow + CameraSealController
   - Player (Capsule) + Rigidbody + InputHandler
   - WeatherSystem + WeatherVisuals (Volume)
   - ProceduralChunkGenerator
   - AILogManager
   - FMODManager
   - AnalyticsManager
   - LocalizationManager
   - UI Canvas
B4. Создать .meta для всех новых ассетов

### Фаза C: Исправление скриптов (критично)
C1. Переписать `CameraSealController.cs` с проверкой существования компонента
C2. Добавить в `CameraSealController.cs` fallback на `CinemachineFollow` с `TrackerSettings`
C3. Исправить `BuildValidator.cs` — добавить проверку ошибок компиляции
C4. Исправить `BuildScript.cs` — добавить `BuildOptions.Development` для диагностики
C5. Добавить defensive programming в `WeatherVisuals`, `ProceduralChunkGenerator`
C6. Обновить `AnalyticsManager` для graceful degradation без сервисов

### Фаза D: Оптимизация CI/CD
D1. Оптимизировать `build.yml`:
   - Добавить `unity-builder` с `customImage` для Unity 6
   - Добавить `cache` для `Library` и `Packages`
   - Добавить `timeout-minutes`
   - Добавить `continue-on-error` для не-критичных шагов
   - Добавить artifact retention
D2. Добавить `unity-test-runner` для проверки перед сборкой
D3. Добавить `BuildOptions.CleanBuildCache` для чистых сборок

### Фаза E: Верификация
E1. Проверить консистентность всех GUID
E2. Проверить что все ссылки в сценах валидны
E3. Создать `CI_VALIDATION_REPORT.md`

## 4. Реализация (IMPLEMENT)
[См. соответствующие коммиты]

## 5. Проверка (KNOW)
[См. CI_VALIDATION_REPORT.md после запуска CI]

---

## Источники и документация

1. Cinemachine 3.x API Migration Guide:
   https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/whats-new.html

2. CinemachineThirdPersonFollow.Damping (Vector3):
   https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/api/Unity.Cinemachine.CinemachineThirdPersonFollow.html

3. CinemachineFollow.TrackerSettings:
   https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/api/Unity.Cinemachine.CinemachineFollow.html

4. Unity 6 Project Settings Structure:
   https://docs.unity3d.com/6000.0/Documentation/Manual/ProjectSettings.html

5. Game CI Unity Builder:
   https://game.ci/docs/github/builder

6. URP Global Settings Unity 6:
   https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@17.0/manual/urp-global-settings.html

7. Barracuda deprecated → Sentis:
   https://docs.unity3d.com/Packages/com.unity.sentis@2.1/manual/index.html

8. GitHub Actions Cache:
   https://github.com/actions/cache
