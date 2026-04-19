using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;
using System.Linq;

public class BuildValidator : MonoBehaviour
{
    // Этот метод вызывается из CI/CD вместо BuildScript.PerformBuild
    public static void ForceBuild()
    {
        Debug.Log("[BuildValidator] Starting forced build sequence...");

        // 1. Принудительно добавляем сцену Main.unity в сборку, если её нет
        EnsureSceneInBuild("Assets/Scenes/Main.unity");

        // 2. Проверяем наличие URP Asset
        ValidateURPSettings();

        // 3. Запускаем сборку
        PerformActualBuild();
    }

    private static void EnsureSceneInBuild(string scenePath)
    {
        var scenes = EditorBuildSettings.scenes;
        
        // Если сцен нет или главная сцена не первая
        if (scenes.Length == 0 || !scenes.Any(s => s.path == scenePath && s.enabled))
        {
            Debug.Log($"[BuildValidator] Scene '{scenePath}' not found in build settings. Adding it.");
            
            // Создаем новый массив сцен, добавляя нашу сцену в начало
            var newScenes = new EditorBuildSettingsScene[scenes.Length + 1];
            newScenes[0] = new EditorBuildSettingsScene(scenePath, true);
            if (scenes.Length > 0)
                scenes.CopyTo(newScenes, 1);
            
            EditorBuildSettings.scenes = newScenes;
            Debug.Log("[BuildValidator] Scene added successfully.");
        }
        else
        {
            Debug.Log("[BuildValidator] Main scene is already in build settings.");
        }
    }

    private static void ValidateURPSettings()
    {
        var urpAsset = GraphicsSettings.currentRenderPipeline as UniversalRenderPipelineAsset;
        if (urpAsset == null)
        {
            Debug.LogWarning("[BuildValidator] URP Asset not assigned! Trying to find one...");
            // Можно добавить логику поиска URP ассета в проекте
        }
        else
        {
            Debug.Log($"[BuildValidator] URP Asset found: {urpAsset.name}");
        }
    }

    private static void PerformActualBuild()
    {
        string[] scenes = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
        
        if (scenes.Length == 0)
        {
            Debug.LogError("[BuildValidator] No scenes enabled in build settings! Aborting.");
            return;
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = "build/StandaloneWindows64/WhitecoatPerpetual.exe",
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.None
        };

        Debug.Log("[BuildValidator] Starting build process...");
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        
        if (report.summary.result == BuildResult.Succeeded)
        {
            Debug.Log("[BuildValidator] Build succeeded!");
        }
        else if (report.summary.result == BuildResult.Failed)
        {
            Debug.LogError("[BuildValidator] Build failed!");
        }
    }
}
