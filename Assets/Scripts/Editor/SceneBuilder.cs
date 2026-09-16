using System;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using Unity.Cinemachine;
using UnityEngine.InputSystem.UI;
using UnityEngine.UI;

/// <summary>
/// Программная сборка сцены Main.unity: свет, океан, дно, игрок, камера Cinemachine,
/// менеджеры, погода, звук, UI, спавнеры, касатка, рыбные школы.
/// Сцена детерминирована — CI пересобирает её перед каждым билдом.
/// </summary>
public static class SceneBuilder
{
    private const string ScenePath = "Assets/Scenes/Main.unity";

    [MenuItem("Whitecoat/Build Scene (Auto)", priority = 0)]
    public static void BuildSceneMenu()
    {
        EnsureBuilt(force: true);
        AssetDatabase.SaveAssets();
    }

    /// <summary>Вызывается из BuildValidator перед сборкой билда.</summary>
    public static void EnsureBuilt(bool force = false)
    {
        if (!force && !SessionState.GetBool("wc_scene_dirty", true) && File.Exists(ScenePath)) return;

        // 0. Настройки проекта
        ConfigureProjectSettings();

        // 1. Материалы и префабы
        var waterMat = MaterialBuilder.BuildWater();
        var skyMat = MaterialBuilder.BuildSky();
        var sandMat = MaterialBuilder.Build("sand", "tex_sand", 0.95f, "tex_noise_n");

        var sealPupPrefab = PrefabBuilder.BuildSeal("seal_pup.fbx", "SealPup",
            new[] { "SealSwim", "SealIdle", "SealWaddle", "SealBark", "SealEat" });
        var sealAdultPrefab = PrefabBuilder.BuildSeal("seal_adult.fbx", "SealAdult",
            new[] { "SealSwim", "SealIdle", "SealWaddle", "SealBark", "SealEat" });
        var orcaPrefab = PrefabBuilder.BuildOrca();
        var fishPrefab = PrefabBuilder.BuildFish();
        var floeS = PrefabBuilder.BuildStaticProp("ice_floe_s.fbx", "IceFloeS", true, iceLayer: true, addIceFloe: true);
        var floeM = PrefabBuilder.BuildStaticProp("ice_floe_m.fbx", "IceFloeM", true, iceLayer: true, addIceFloe: true);
        var floeL = PrefabBuilder.BuildStaticProp("ice_floe_l.fbx", "IceFloeL", true, iceLayer: true, addIceFloe: true);
        var floeHole = PrefabBuilder.BuildStaticProp("ice_hole_floe.fbx", "IceHoleFloe", true, iceLayer: true,
            addIceFloe: true, addHole: true);
        var iceberg = PrefabBuilder.BuildStaticProp("iceberg.fbx", "Iceberg", true, iceLayer: true, addIceFloe: true);
        var rockA = PrefabBuilder.BuildStaticProp("rock_a.fbx", "RockA", true);
        var rockB = PrefabBuilder.BuildStaticProp("rock_b.fbx", "RockB", true);
        var kelp = PrefabBuilder.BuildStaticProp("kelp.fbx", "Kelp", false);
        var coralA = PrefabBuilder.BuildStaticProp("coral_a.fbx", "CoralA", false);
        var coralB = PrefabBuilder.BuildStaticProp("coral_b.fbx", "CoralB", false);
        var clam = PrefabBuilder.BuildStaticProp("clam.fbx", "Clam", true);
        var krill = PrefabBuilder.BuildKrillPickup(null);

        // Community (CC0): ambient-косатка + рифовые рыбы (см. Community/ATTRIBUTION.md)
        var whalePrefab = PrefabBuilder.BuildCommunityWhale();
        var fishAPrefab = PrefabBuilder.BuildCommunityFish("fish_a.fbx", "ReefFishA",
            new Color(0.55f, 0.68f, 0.80f)); // серебристо-голубая
        var fishBPrefab = PrefabBuilder.BuildCommunityFish("fish_b.fbx", "ReefFishB",
            new Color(0.85f, 0.55f, 0.30f)); // коралловая
        var fishCPrefab = PrefabBuilder.BuildCommunityFish("fish_c.fbx", "ReefFishC",
            new Color(0.88f, 0.78f, 0.42f)); // песочная

        // 2. Новая сцена
        var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);

        // --- Skybox и туман ---
        RenderSettings.skybox = skyMat;
        RenderSettings.fog = true;
        RenderSettings.fogMode = FogMode.Linear;
        RenderSettings.fogStartDistance = 60f;
        RenderSettings.fogEndDistance = 400f;
        RenderSettings.fogColor = new Color(0.72f, 0.80f, 0.88f);
        RenderSettings.ambientMode = AmbientMode.Flat; // UnityEngine.Rendering.AmbientMode (Unity 6)
        RenderSettings.ambientLight = new Color(0.45f, 0.52f, 0.60f);

        // --- Системы ---
        var systems = new GameObject("Systems");
        systems.AddComponent<GameManager>();
        systems.AddComponent<InputRouter>();
        var loc = systems.AddComponent<LocalizationManager>();
        loc.stringsCsv = AssetDatabase.LoadAssetAtPath<TextAsset>("Assets/Data/Loc/strings.csv");
        systems.AddComponent<GeneticsManager>();
        systems.AddComponent<AnalyticsManager>();
        systems.AddComponent<ChunkSpawner>();
        var weatherGo = new GameObject("WeatherSystem");
        weatherGo.transform.SetParent(systems.transform, false);
        weatherGo.AddComponent<WeatherSystem>();
        var day = systems.AddComponent<DayNightCycle>();

        // --- Свет ---
        var sunPivot = new GameObject("SunPivot");
        var sunGo = new GameObject("Sun");
        sunGo.transform.SetParent(sunPivot.transform, false);
        var sun = sunGo.AddComponent<Light>();
        sun.type = LightType.Directional;
        sun.color = new Color(1f, 0.94f, 0.84f);
        sun.intensity = 1.1f;
        sun.shadows = LightShadows.Soft;
        sun.shadowStrength = 0.85f;
        sunGo.transform.localRotation = Quaternion.Euler(45f, 35f, 0f);

        var moonGo = new GameObject("Moon");
        var moon = moonGo.AddComponent<Light>();
        moon.type = LightType.Directional;
        moon.color = new Color(0.55f, 0.65f, 0.9f);
        moon.intensity = 0.2f;
        moon.shadows = LightShadows.None;
        moonGo.transform.rotation = Quaternion.Euler(-35f, 140f, 0f);

        day.sun = sun;
        day.moon = moon;
        day.sunPivot = sunPivot.transform;

        // --- Океан ---
        var oceanGo = new GameObject("Ocean");
        var oceanMesh = BuildGridMesh(600f, 220, waveNoise: 0f);
        var oceanFilter = oceanGo.AddComponent<MeshFilter>();
        oceanFilter.sharedMesh = oceanMesh;
        var oceanRenderer = oceanGo.AddComponent<MeshRenderer>();
        oceanRenderer.sharedMaterial = waterMat;
        oceanRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        oceanGo.AddComponent<OceanManager>();
        oceanGo.layer = LayerMask.NameToLayer("Water");

        // --- Дно ---
        var floorGo = new GameObject("SeaFloor");
        var floorMesh = BuildGridMesh(600f, 140, waveNoise: 1.6f);
        var floorFilter = floorGo.AddComponent<MeshFilter>();
        floorFilter.sharedMesh = floorMesh;
        var floorRenderer = floorGo.AddComponent<MeshRenderer>();
        floorRenderer.sharedMaterial = sandMat;
        floorRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        floorGo.transform.position = new Vector3(0, GameConfig.SeaFloorY, 0);
        var floorCol = floorGo.AddComponent<BoxCollider>();
        floorCol.size = new Vector3(600f, 2f, 600f);
        floorCol.center = new Vector3(0, -1f, 0);

        // --- Стартовая льдина с прорубью ---
        var startFloe = (GameObject)PrefabUtility.InstantiatePrefab(floeM);
        startFloe.name = "StartFloe";
        startFloe.transform.position = Vector3.zero;
        var startHole = (GameObject)PrefabUtility.InstantiatePrefab(floeHole);
        startHole.name = "StartHoleFloe";
        startHole.transform.position = new Vector3(9f, 0f, 2f);

        // --- Игрок ---
        var player = (GameObject)PrefabUtility.InstantiatePrefab(sealPupPrefab);
        player.name = "Player";
        player.tag = "Player";
        player.transform.position = new Vector3(0f, 1.2f, 0f);
        player.AddComponent<SealStats>();
        player.AddComponent<SealController>();
        player.AddComponent<SealAnimatorDriver>();

        var stats = player.GetComponent<SealStats>();

        // Визуалы стадий: pup уже внутри (FBX-иерархия), adult добавим
        var adultModel = (GameObject)PrefabUtility.InstantiatePrefab(sealAdultPrefab);
        adultModel.name = "AdultVisual";
        adultModel.transform.SetParent(player.transform, false);
        adultModel.transform.localPosition = Vector3.zero;
        adultModel.SetActive(false);

        // Unity 6: переносить ДЕТЕЙ префаб-инстанса нельзя ("Setting the parent ... is not possible").
        // Визуал белька = арматурная ветка "SealRig" внутри инстанса — её и переключаем по стадиям.
        var pupRig = player.transform.Find("SealRig");
        var pupVisualGo = pupRig != null ? pupRig.gameObject : player;

        var stage = player.AddComponent<SealStageSystem>();
        stage.pupVisual = pupVisualGo;
        stage.adultVisual = adultModel;

        // Точка головы
        var headGo = new GameObject("HeadPoint");
        headGo.transform.SetParent(player.transform, false);
        headGo.transform.localPosition = new Vector3(0f, 0.25f, 0.62f);

        var ctrl = player.GetComponent<SealController>();
        ctrl.headPoint = headGo.transform;

        // --- Камера ---
        var camGo = new GameObject("Main Camera");
        camGo.tag = "MainCamera";
        var cam = camGo.AddComponent<Camera>();
        cam.fieldOfView = 50f;
        cam.nearClipPlane = 0.1f;
        cam.farClipPlane = 700f;
        cam.clearFlags = CameraClearFlags.Skybox;
        camGo.AddComponent<AudioListener>();
        camGo.AddComponent<UniversalAdditionalCameraData>().renderPostProcessing = true;
        camGo.AddComponent<CinemachineBrain>();
        camGo.transform.position = new Vector3(0, 3, -8);

        // Погодные частицы — дети камеры
        var snowPS = MakeSnowPS(camGo.transform, "SnowPS");
        var rainPS = MakeRainPS(camGo.transform, "RainPS");
        var windPS = MakeWindPS(camGo.transform, "WindPS");

        // --- Cinemachine ---
        var vcamGo = new GameObject("SealCamera");
        var vcam = vcamGo.AddComponent<CinemachineCamera>();
        vcam.Lens.FieldOfView = 45f;
        vcam.Priority = new PrioritySettings { Enabled = true, Value = 10 };
        var tp = vcamGo.AddComponent<CinemachineThirdPersonFollow>();
        tp.CameraDistance = 6f;
        tp.VerticalArmLength = 2.5f;
        tp.Damping = new Vector3(0.8f, 0.8f, 0.8f);
        tp.ShoulderOffset = new Vector3(0.4f, -0.2f, 0);
        var camCtrl = vcamGo.AddComponent<CameraSealController>();
        camCtrl.followTarget = player.transform;

        // --- Пост-обработка: глобальный Volume ---
        var volumeGo = new GameObject("GlobalVolume");
        var volume = volumeGo.AddComponent<Volume>();
        volume.isGlobal = true;
        volume.weight = 1f;
        var profile = ScriptableObject.CreateInstance<VolumeProfile>();
        var ca = profile.Add<ColorAdjustments>();
        ca.postExposure.Override(0.15f);
        var vig = profile.Add<Vignette>();
        vig.intensity.Override(0.18f);
        vig.smoothness.Override(0.45f);
        AssetDatabase.CreateAsset(profile, "Assets/Settings/GameVolumeProfile.asset");
        volume.sharedProfile = profile;

        // --- Погода-визуал ---
        var weatherVisGo = new GameObject("WeatherVisuals");
        var wv = weatherVisGo.AddComponent<WeatherVisuals>();
        wv.snowPS = snowPS;
        wv.rainPS = rainPS;
        wv.windPS = windPS;
        var wvProfile = ScriptableObject.CreateInstance<VolumeProfile>();
        var vig2 = wvProfile.Add<Vignette>();
        vig2.intensity.Override(0.18f);
        AssetDatabase.CreateAsset(wvProfile, "Assets/Settings/WeatherVolumeProfile.asset");
        weatherVisGo.AddComponent<Volume>().sharedProfile = wvProfile;

        // --- Подводные эффекты ---
        var uwGo = new GameObject("UnderwaterFX");
        uwGo.AddComponent<UnderwaterFX>();
        var bioGo = new GameObject("Bioluminescence");
        var bio = bioGo.AddComponent<Bioluminescence>();
        bio.planktonPS = MakePlanktonPS(uwGo.transform, "PlanktonPS");
        var glowA = new GameObject("GlowA");
        glowA.transform.SetParent(bioGo.transform, false);
        var lightA = glowA.AddComponent<Light>();
        lightA.type = LightType.Point;
        lightA.range = 9f;
        lightA.intensity = 0f;
        var glowB = new GameObject("GlowB");
        glowB.transform.SetParent(bioGo.transform, false);
        var lightB = glowB.AddComponent<Light>();
        lightB.type = LightType.Point;
        lightB.range = 14f;
        lightB.intensity = 0f;
        bio.glowLightA = lightA;
        bio.glowLightB = lightB;

        // --- Аудио ---
        var audioGo = new GameObject("AudioDirector");
        var audioDir = audioGo.AddComponent<AudioDirector>();
        audioDir.musicSource = MakeAudioSource(audioGo.transform, "Music", "Audio/music_pad", 0.55f);
        audioDir.ambientSource = MakeAudioSource(audioGo.transform, "Ambient", "Audio/ambient_ocean", 0.55f);
        audioDir.underwaterSource = MakeAudioSource(audioGo.transform, "Underwater", "Audio/ambient_underwater", 0f);
        audioDir.sfx.Add(Sfx("bark", "Audio/seal_bark", 0.9f, 4, 40));
        audioDir.sfx.Add(Sfx("eat", "Audio/seal_eat", 0.8f, 3, 25));
        audioDir.sfx.Add(Sfx("splash", "Audio/splash", 0.8f, 5, 50));
        audioDir.sfx.Add(Sfx("orca_call", "Audio/orca_call", 0.9f, 8, 90));
        audioDir.sfx.Add(Sfx("orca_danger", "Audio/orca_danger", 0.95f, 8, 90));
        audioDir.sfx.Add(Sfx("bite", "Audio/bite", 0.95f, 5, 60));
        audioDir.sfx.Add(Sfx("heartbeat", "Audio/heartbeat", 0.7f, 999, 999));
        audioDir.sfx.Add(Sfx("breath", "Audio/breath", 0.7f, 999, 999));
        audioDir.sfx.Add(Sfx("swish", "Audio/swish", 0.6f, 3, 20));
        audioDir.sfx.Add(Sfx("ice_crack", "Audio/ice_crack", 0.9f, 6, 70));
        audioDir.sfx.Add(Sfx("evolve", "Audio/evolve", 0.8f, 999, 999));

        // --- Спавнер ---
        var spawner = systems.GetComponent<ChunkSpawner>();
        spawner.player = player.transform;
        spawner.floes = new[]
        {
            Rule(floeS, 0.40f, -0.5f, 0f, 0.8f, 1.3f, alignWater: true, 0.44f, 0.72f),
            Rule(floeM, 0.30f, -0.5f, 0f, 0.8f, 1.25f, alignWater: true, 0.48f, 0.78f),
            Rule(floeL, 0.18f, -0.5f, 0f, 0.85f, 1.3f, alignWater: true, 0.52f, 0.82f),
            Rule(floeHole, 0.10f, -0.5f, 0f, 0.9f, 1.1f, alignWater: true, 0.50f, 0.72f),
            Rule(iceberg, 0.05f, -2f, 0f, 0.7f, 1.5f, alignWater: true, 0.60f, 0.88f),
        };
        spawner.underwater = new[]
        {
            Rule(rockA, 0.16f, GameConfig.SeaFloorY + 0.5f, -10f, 0.7f, 1.6f, alignWater: false, 0.3f, 0.62f),
            Rule(rockB, 0.20f, GameConfig.SeaFloorY + 0.5f, -12f, 0.7f, 1.7f, alignWater: false, 0.3f, 0.62f),
            Rule(kelp, 0.16f, GameConfig.SeaFloorY, GameConfig.SeaFloorY + 0.5f, 0.8f, 1.5f, alignWater: false, 0.42f, 0.72f),
            Rule(coralA, 0.12f, GameConfig.SeaFloorY + 0.4f, -14f, 0.9f, 1.8f, alignWater: false, 0.34f, 0.58f),
            Rule(coralB, 0.12f, GameConfig.SeaFloorY + 0.4f, -14f, 0.9f, 1.8f, alignWater: false, 0.34f, 0.58f),
            Rule(clam, 0.12f, GameConfig.SeaFloorY + 0.35f, GameConfig.SeaFloorY + 0.5f, 0.8f, 1.4f, alignWater: false, 0.4f, 0.65f),
            Rule(krill, 0.22f, -22f, -6f, 1f, 1.6f, alignWater: false, 0.28f, 0.7f),
        };

        // --- Касатка ---
        var orca = (GameObject)PrefabUtility.InstantiatePrefab(orcaPrefab);
        orca.name = "Orca";
        orca.transform.position = new Vector3(38f, -8f, 30f);

        // --- Рыбные школы ---
        Vector3[] schoolPos = { new Vector3(18, -8, -12), new Vector3(-22, -12, 18), new Vector3(-14, -6, -26) };
        for (int i = 0; i < 3; i++)
        {
            var school = (GameObject)PrefabUtility.InstantiatePrefab(fishPrefab);
            school.name = "FishSchool_" + i;
            school.transform.position = schoolPos[i];
            var fs = school.GetComponent<FishSchool>();
            fs.fishCount = 55;
            fs.schoolRadius = 5f;
        }

        // --- Community (CC0): ambient-косатки вдали + рифовые рыбы у кораллов ---
        if (whalePrefab != null)
        {
            var whaleSpawns = new (Vector3 start, Vector3 center, float radius, float phase)[]
            {
                (new Vector3(-40f, -9f, -35f), new Vector3(-15f, -11f, -15f), 55f, 0.0f),
                (new Vector3(50f, -13f, -20f), new Vector3(10f, -14f, 5f), 70f, 3.1f),
            };
            for (int i = 0; i < whaleSpawns.Length; i++)
            {
                var pivot = new GameObject("AmbientWhalePivot_" + i);
                var whale = (GameObject)PrefabUtility.InstantiatePrefab(whalePrefab);
                whale.transform.SetParent(pivot.transform, false);
                whale.transform.localPosition = Vector3.zero;
                // Исходник ориентирован вертикально (Blender Z-up): нос +Y → кладём на +Z
                whale.transform.localRotation = Quaternion.Euler(90f, 0f, 0f);
                var swim = pivot.AddComponent<AmbientSwimmer>();
                swim.center = whaleSpawns[i].center;
                swim.radius = whaleSpawns[i].radius;
                swim.angularSpeed = 0.05f;
                swim.phase = whaleSpawns[i].phase;
                swim.bobAmp = 1.2f;
                pivot.transform.position = whaleSpawns[i].start;
            }
            Debug.Log("[SceneBuilder] Ambient whales: " + whaleSpawns.Length);
        }

        var reefFishPrefabs = new[] { fishAPrefab, fishBPrefab, fishCPrefab };
        for (int g = 0; g < reefFishPrefabs.Length; g++)
        {
            if (reefFishPrefabs[g] == null) continue;
            for (int j = 0; j < 7; j++)
            {
                var pivot = new GameObject("ReefFish_" + g + "_" + j);
                var fish = (GameObject)PrefabUtility.InstantiatePrefab(reefFishPrefabs[g]);
                fish.transform.SetParent(pivot.transform, false);
                fish.transform.localPosition = Vector3.zero;
                var center = schoolPos[g]
                             + new Vector3(Mathf.Cos(g * 2.1f + j) * 3.5f, 1.5f + 0.4f * j,
                                           Mathf.Sin(g * 2.1f + j) * 3.5f);
                var swim = pivot.AddComponent<AmbientSwimmer>();
                swim.center = center;
                swim.radius = 1.2f + 0.25f * j;
                swim.angularSpeed = 0.7f + 0.09f * j;
                swim.phase = g * 0.9f + j * 0.45f;
                swim.bobAmp = 0.12f;
                pivot.transform.position = center;
            }
            Debug.Log($"[SceneBuilder] Reef fish group {g}: 7");
        }

        // --- UI ---
        var eventSystem = new GameObject("EventSystem");
        eventSystem.AddComponent<EventSystem>();
        eventSystem.AddComponent<InputSystemUIInputModule>();

        var hudGo = new GameObject("HUD", typeof(Canvas));
        hudGo.AddComponent<HUDController>();
        var menuGo = new GameObject("Menus", typeof(Canvas));
        menuGo.AddComponent<MenuController>();

        // 3. Большой Мир: хаб Тёплая Бухта + реалмы (Fab-пакеты), старт в хабе
        var playerGo = GameObject.Find("Player");
        HubRealmBuilder.BuildInto(playerGo ? playerGo.transform : null);

        // 4. Сохранение сцены
        Directory.CreateDirectory("Assets/Scenes");
        EditorSceneManager.SaveScene(scene, ScenePath);

        // 5. Build Settings
        var buildScenes = new[] { new EditorBuildSettingsScene(ScenePath, true) };
        EditorBuildSettings.scenes = buildScenes;

        SessionState.SetBool("wc_scene_dirty", false);
        Debug.Log("[SceneBuilder] Scene built: " + ScenePath);
    }

    // ---------- Хелперы ----------
    private static ChunkSpawner.SpawnRule Rule(GameObject prefab, float density, float yMin, float yMax,
        float sMin, float sMax, bool alignWater, float bandMin, float bandMax)
    {
        return new ChunkSpawner.SpawnRule
        {
            prefab = prefab,
            density = density,
            yMin = yMin,
            yMax = yMax,
            scaleMin = sMin,
            scaleMax = sMax,
            alignToWater = alignWater,
            noiseBandMin = bandMin,
            noiseBandMax = bandMax
        };
    }

    private static AudioDirector.SfxEntry Sfx(string key, string path, float vol, float minD, float maxD)
    {
        return new AudioDirector.SfxEntry
        {
            key = key,
            clip = AssetDatabase.LoadAssetAtPath<AudioClip>(path + ".wav"),
            volume = vol,
            minDistance = minD,
            maxDistance = maxD
        };
    }

    private static AudioSource MakeAudioSource(Transform parent, string name, string clipPath, float vol)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        var src = go.AddComponent<AudioSource>();
        src.clip = AssetDatabase.LoadAssetAtPath<AudioClip>(clipPath + ".wav");
        src.loop = true;
        src.playOnAwake = true;
        src.spatialBlend = 0f;
        src.volume = vol;
        return src;
    }

    private static ParticleSystem MakeSnowPS(Transform parent, string name)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        go.transform.localPosition = new Vector3(0, 14f, 0);
        var ps = go.AddComponent<ParticleSystem>();
        var main = ps.main;
        main.startSize = new ParticleSystem.MinMaxCurve(0.06f, 0.16f);
        main.startLifetime = 3.2f;
        main.startSpeed = new ParticleSystem.MinMaxCurve(2f, 4f);
        main.maxParticles = 3000;
        main.startColor = new Color(0.95f, 0.97f, 1f, 0.85f);
        main.gravityModifier = 0.35f;
        var em = ps.emission;
        em.rateOverTime = 0f; // управляет WeatherVisuals
        var sh = ps.shape;
        sh.shapeType = ParticleSystemShapeType.Box;
        sh.scale = new Vector3(44f, 1f, 44f);
        var col = ps.colorOverLifetime;
        col.enabled = true;
        var fadeGrad = new Gradient();
        fadeGrad.SetKeys(
            new[] { new GradientColorKey(Color.white, 0f), new GradientColorKey(Color.white, 1f) },
            new[] { new GradientAlphaKey(0f, 0f), new GradientAlphaKey(1f, 0.15f), new GradientAlphaKey(0f, 1f) });
        col.color = new ParticleSystem.MinMaxGradient(fadeGrad);
        var sr = ps.GetComponent<ParticleSystemRenderer>();
        sr.material = new Material(Shader.Find("Universal Render Pipeline/Particles/Unlit"));
        sr.material.SetColor("_BaseColor", new Color(1f, 1f, 1f, 0.8f));
        sr.renderMode = ParticleSystemRenderMode.Billboard;
        return ps;
    }

    private static ParticleSystem MakeRainPS(Transform parent, string name)
    {
        var ps = MakeSnowPS(parent, name);
        var main = ps.main;
        main.startSize = new ParticleSystem.MinMaxCurve(0.03f, 0.05f);
        main.startLifetime = 1.6f;
        main.startSpeed = new ParticleSystem.MinMaxCurve(9f, 12f);
        main.startColor = new Color(0.75f, 0.85f, 0.95f, 0.6f);
        var sh = ps.shape;
        sh.scale = new Vector3(36f, 1f, 36f);
        ps.gameObject.SetActive(true);
        return ps;
    }

    private static ParticleSystem MakeWindPS(Transform parent, string name)
    {
        var ps = MakeSnowPS(parent, name);
        var main = ps.main;
        main.startSize = new ParticleSystem.MinMaxCurve(0.03f, 0.08f);
        main.startLifetime = 2.2f;
        main.startSpeed = new ParticleSystem.MinMaxCurve(6f, 10f);
        main.startColor = new Color(1f, 1f, 1f, 0.35f);
        var vel = ps.velocityOverLifetime;
        vel.enabled = true;
        vel.x = new ParticleSystem.MinMaxCurve(8f, 14f);
        vel.y = new ParticleSystem.MinMaxCurve(-0.4f, 0.4f);
        ps.transform.localPosition = new Vector3(0, 1f, 0);
        return ps;
    }

    private static ParticleSystem MakePlanktonPS(Transform parent, string name)
    {
        var go = new GameObject(name);
        go.transform.SetParent(parent, false);
        var ps = go.AddComponent<ParticleSystem>();
        var main = ps.main;
        main.startSize = new ParticleSystem.MinMaxCurve(0.03f, 0.09f);
        main.startLifetime = 4f;
        main.startSpeed = new ParticleSystem.MinMaxCurve(0.1f, 0.5f);
        main.maxParticles = 800;
        main.startColor = new Color(0.4f, 0.9f, 1f, 0.8f);
        main.simulationSpace = ParticleSystemSimulationSpace.World;
        var em = ps.emission;
        em.rateOverTime = 0f;
        var sh = ps.shape;
        sh.shapeType = ParticleSystemShapeType.Sphere;
        sh.radius = 12f;
        var sr = ps.GetComponent<ParticleSystemRenderer>();
        sr.material = new Material(Shader.Find("Universal Render Pipeline/Particles/Unlit"));
        sr.material.SetColor("_BaseColor", new Color(0.5f, 1f, 1f, 0.9f));
        return ps;
    }

    private static Mesh BuildGridMesh(float size, int segments, float waveNoise)
    {
        var mesh = new Mesh();
        int v = segments + 1;
        var verts = new Vector3[v * v];
        var uvs = new Vector2[v * v];
        var tris = new int[segments * segments * 6];
        float half = size / 2f;
        float step = size / segments;

        // Плоскость в XZ (Unity), нормаль вверх
        for (int z = 0; z < v; z++)
        {
            for (int x = 0; x < v; x++)
            {
                int idx = z * v + x;
                float wx = -half + x * step;
                float wz = -half + z * step;
                float y = 0f;
                if (waveNoise > 0f)
                {
                    y = (Mathf.PerlinNoise((wx + 500) * 0.02f, (wz + 500) * 0.02f) - 0.5f) * 2f * waveNoise
                      + (Mathf.PerlinNoise((wx + 100) * 0.06f, (wz + 100) * 0.06f) - 0.5f) * 0.7f * waveNoise;
                }
                verts[idx] = new Vector3(wx, y, wz);
                uvs[idx] = new Vector2((float)x / segments, (float)z / segments);
            }
        }
        int t = 0;
        for (int z = 0; z < segments; z++)
        {
            for (int x = 0; x < segments; x++)
            {
                int a = z * v + x;
                int b = a + 1;
                int c = a + v;
                int d = c + 1;
                tris[t++] = a; tris[t++] = c; tris[t++] = b;
                tris[t++] = b; tris[t++] = c; tris[t++] = d;
            }
        }
        mesh.vertices = verts;
        mesh.uv = uvs;
        mesh.triangles = tris;
        mesh.RecalculateNormals();
        // Гарантия: нормали вверх (иначе переворачиваем winding)
        if (mesh.normals.Length > 0 && mesh.normals[0].y < 0f)
        {
            for (int i = 0; i < tris.Length; i += 3)
            {
                (tris[i], tris[i + 2]) = (tris[i + 2], tris[i]);
            }
            mesh.triangles = tris;
            mesh.RecalculateNormals();
        }
        mesh.RecalculateBounds();
        return mesh;
    }

    private static void ConfigureProjectSettings()
    {
        // Depth texture в URP-ассетах
        foreach (var path in new[] { "Assets/Settings/UniversalRP.asset" })
        {
            var asset = AssetDatabase.LoadAssetAtPath<UniversalRenderPipelineAsset>(path);
            if (asset == null) continue;
            var so = new SerializedObject(asset);
            var prop = so.FindProperty("m_SupportsDepthTexture") ?? so.FindProperty("m_DepthTexture");
            if (prop != null)
            {
                prop.boolValue = true;
                so.ApplyModifiedPropertiesWithoutUndo();
            }
            var hdr = so.FindProperty("m_SupportsHDR");
            if (hdr != null)
            {
                hdr.boolValue = true;
                so.ApplyModifiedPropertiesWithoutUndo();
            }
        }

        // Active Input Handling = Both (2)
        var settingsObjects = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/ProjectSettings.asset");
        if (settingsObjects != null && settingsObjects.Length > 0)
        {
            var so = new SerializedObject(settingsObjects[0]);
            var prop = so.FindProperty("activeInputHandler");
            if (prop != null)
            {
                prop.intValue = 2;
                so.ApplyModifiedPropertiesWithoutUndo();
            }
        }
    }
}
