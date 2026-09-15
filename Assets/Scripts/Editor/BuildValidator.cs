using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.Rendering;

/// <summary>
/// Точка входа CI/CD (Game CI / Unity Builder): BuildValidator.ForceBuild.
/// Пересобирает сцену программно, затем билдит Windows-таргет.
/// </summary>
public static class BuildValidator
{
    private const string OutputPath = "build/StandaloneWindows64/WhitecoatPerpetual.exe";

    public static void ForceBuild()
    {
        Debug.Log("[BuildValidator] Starting forced build sequence...");

        // 1. Программная пересборка сцены (детерминированная)
        SceneBuilder.EnsureBuilt(force: true);
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);

        // 2. Проверка URP
        ValidateURPSettings();

        // 3. Сцена в билд-настройках
        EnsureSceneInBuild("Assets/Scenes/Main.unity");

        // 4. Сборка
        var options = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/Main.unity" },
            locationPathName = OutputPath,
            target = BuildTarget.StandaloneWindows64,
            targetGroup = BuildTargetGroup.Standalone,
            options = BuildOptions.None
        };

        Debug.Log("[BuildValidator] Building Windows64...");
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
            Debug.LogWarning("[BuildValidator] URP Asset not assigned! Build may fail at runtime.");
        }
        else
        {
            Debug.Log($"[BuildValidator] URP Asset: {urpAsset.name}");
        }
    }
}
