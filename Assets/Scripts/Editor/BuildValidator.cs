using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.Rendering;

/// <summary>
/// Точка входа CI/CD (Game CI / Unity Builder): BuildValidator.ForceBuild.
/// Пересобирает сцену программно, затем билдит таргет из -buildTarget
/// (StandaloneWindows64 → .exe, StandaloneOSX → .app / Apple Silicon).
///
/// Фикс «розового экрана/зависания» на старых GPU (Radeon RX Vega 56, Polaris):
///  1) Graphics Jobs отключены (ProjectSettings m_GraphicsJobs: 0) — известные
///     зависания драйвера при gfx-enable-gfx-jobs=1;
///  2) графический API закреплён: D3D11 для Windows, Metal для macOS —
///     исключаем авто-выбор D3D12/Vulkan на старых драйверах;
///  3) Always Included Shaders заполнены — ранее список был пуст и URP-варианты,
///     запрашиваемые в рантайме, могли быть вырезаны стриппингом (розовые материалы);
///  4) URP-ассет прописан во ВСЕ уровни QualitySettings (иначе билд-тайм и
///     рантайм могли использовать разные пайплайны → расхождение вариантов).
/// </summary>
public static class BuildValidator
{
    // Шейдеры, обязанные попасть в билд с полным набором вариантов.
    private static readonly string[] AlwaysIncluded =
    {
        "Universal Render Pipeline/Lit",
        "Universal Render Pipeline/SimpleLit",
        "Universal Render Pipeline/Unlit",
        "Universal Render Pipeline/Baked Lit",
        "Universal Render Pipeline/Particles/Lit",
        "Universal Render Pipeline/Particles/Unlit",
        "Skybox/Panoramic",
        "Whitecoat/OceanWater",
        "Whitecoat/ArcticSky",
        "UI/Default",
        "Sprites/Default",
    };

    public static void ForceBuild()
    {
        Debug.Log("[BuildValidator] Starting forced build sequence...");

        // 0. Таргет из CLI (-buildTarget)
        var target = EditorUserBuildSettings.activeBuildTarget;
        string output = target == BuildTarget.StandaloneOSX
            ? "build/StandaloneOSX/WhitecoatPerpetual.app"
            : "build/StandaloneWindows64/WhitecoatPerpetual.exe";

        // 1. Программная пересборка сцены (детерминированная)
        SceneBuilder.EnsureBuilt(force: true);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);

        // 2. Стабильные настройки рендера плеера (API, шейдеры, quality)
        ApplyStablePlayerSettings(target);
        ValidateURPSettings();

        // 3. Сцена в билд-настройках
        EnsureSceneInBuild("Assets/Scenes/Main.unity");

        // 4. Сборка
        var options = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/Main.unity" },
            locationPathName = output,
            target = target,
            targetGroup = BuildTargetGroup.Standalone,
            options = BuildOptions.None
        };

        Debug.Log($"[BuildValidator] Building {target} -> {output} ...");
        BuildReport report = BuildPipeline.BuildPlayer(options);

        if (report.summary.result == BuildResult.Succeeded)
        {
            Debug.Log($"[BuildValidator] Build succeeded! Size: {report.summary.totalSize} bytes");
        }
        else
        {
            Debug.LogError("[BuildValidator] Build failed!");
            EditorApplication.Exit(1);
        }
    }

    /// <summary>
    /// Закрепляет настройки, от которых зависела стабильность картинки в плеере.
    /// Выполняется на каждой сборке — детерминированно, без ручных правок YAML.
    /// </summary>
    private static void ApplyStablePlayerSettings(BuildTarget target)
    {
        // --- Графические API: без авто-выбора (D3D12/Vulkan глючат на старых AMD) ---
        if (target == BuildTarget.StandaloneWindows64)
        {
            PlayerSettings.SetUseDefaultGraphicsAPIs(target, false);
            PlayerSettings.SetGraphicsAPIs(target, new[] { GraphicsDeviceType.Direct3D11 });
            Debug.Log("[BuildValidator] Windows graphics API pinned: Direct3D11 (Vega/Polaris safe)");
        }
        else if (target == BuildTarget.StandaloneOSX)
        {
            PlayerSettings.SetUseDefaultGraphicsAPIs(target, false);
            PlayerSettings.SetGraphicsAPIs(target, new[] { GraphicsDeviceType.Metal });
            Debug.Log("[BuildValidator] macOS graphics API pinned: Metal");
        }

        // --- Always Included Shaders (m_AlwaysIncludedShaders был пуст!) ---
        var gsAssets = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/GraphicsSettings.asset");
        if (gsAssets != null && gsAssets.Length > 0)
        {
            var found = new List<Shader>();
            foreach (var name in AlwaysIncluded)
            {
                var sh = Shader.Find(name);
                if (sh == null) { Debug.LogWarning($"[BuildValidator] Shader not found: {name}"); continue; }
                found.Add(sh);
            }

            var so = new SerializedObject(gsAssets[0]);
            var prop = so.FindProperty("m_AlwaysIncludedShaders");
            if (prop != null && prop.isArray)
            {
                prop.arraySize = found.Count;
                for (int i = 0; i < found.Count; i++)
                    prop.GetArrayElementAtIndex(i).objectReferenceValue = found[i];
                so.ApplyModifiedPropertiesWithoutUndo();
                AssetDatabase.SaveAssets();
                Debug.Log($"[BuildValidator] AlwaysIncludedShaders: {found.Count}/{AlwaysIncluded.Length} pinned");
            }
            else
            {
                Debug.LogWarning("[BuildValidator] m_AlwaysIncludedShaders property not found");
            }
        }

        // --- URP-ассет во ВСЕ уровни QualitySettings ---
        var urp = GraphicsSettings.defaultRenderPipeline;
        if (urp != null)
        {
            var qAssets = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/QualitySettings.asset");
            if (qAssets != null && qAssets.Length > 0)
            {
                var qso = new SerializedObject(qAssets[0]);
                var levels = qso.FindProperty("m_QualitySettings");
                if (levels != null && levels.isArray)
                {
                    for (int i = 0; i < levels.arraySize; i++)
                    {
                        var e = levels.GetArrayElementAtIndex(i).FindPropertyRelative("customRenderPipeline");
                        if (e != null) e.objectReferenceValue = urp;
                    }
                    qso.ApplyModifiedPropertiesWithoutUndo();
                    AssetDatabase.SaveAssets();
                    Debug.Log($"[BuildValidator] QualitySettings: URP asset assigned to {levels.arraySize} level(s)");
                }
            }
        }
    }

    private static void EnsureSceneInBuild(string scenePath)
    {
        var scenes = EditorBuildSettings.scenes;
        if (scenes.Length == 0 || !System.Array.Exists(scenes, s => s.path == scenePath && s.enabled))
        {
            var newScenes = new EditorBuildSettingsScene[1];
            newScenes[0] = new EditorBuildSettingsScene(scenePath, true);
            EditorBuildSettings.scenes = newScenes;
            Debug.Log($"[BuildValidator] Scene '{scenePath}' added to build settings.");
        }
    }

    private static void ValidateURPSettings()
    {
        var urpAsset = GraphicsSettings.defaultRenderPipeline; // UnityEngine.Rendering.GraphicsSettings (Unity 6)
        if (urpAsset == null)
        {
            Debug.LogError("[BuildValidator] URP Asset not assigned! Build would render pink.");
            EditorApplication.Exit(1);
        }
        else
        {
            Debug.Log($"[BuildValidator] URP Asset: {urpAsset.name}");
        }
    }
}
