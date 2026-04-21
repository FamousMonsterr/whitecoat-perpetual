using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;
using System.Linq;

/// <summary>
/// Скрипт принудительной сборки для CI/CD (Game CI / Unity Builder).
/// Вызывается через buildMethod: BuildValidator.ForceBuild
/// Документация: https://game.ci/docs/github/builder
/// </summary>
public class BuildValidator
{
    // Целевая сцена сборки
    private const string MAIN_SCENE_PATH = "Assets/Scenes/Main.unity";
    
    // Путь выходного билда
    private const string OUTPUT_PATH = "build/StandaloneWindows64/WhitecoatPerpetual.exe";

    /// <summary>
    /// Метод сборки, вызываемый из CI.
    /// </summary>
    public static void ForceBuild()
    {
        Debug.Log("[BuildValidator] Starting forced build sequence...");

        // 1. Принудительно добавляем сцену Main.unity в сборку
        EnsureSceneInBuild(MAIN_SCENE_PATH);

        // 2. Проверяем наличие URP Asset
        ValidateURPSettings();
        
        // 3. Проверяем что нет ошибок компиляции
        if (HasCompileErrors())
        {
            Debug.LogError("[BuildValidator] Compile errors detected! Aborting build.");
            EditorApplication.Exit(1);
            return;
        }

        // 4. Запускаем сборку
        PerformActualBuild();
    }

    private static void EnsureSceneInBuild(string scenePath)
    {
        var scenes = EditorBuildSettings.scenes;
        
        if (scenes.Length == 0 || !scenes.Any(s => s.path == scenePath && s.enabled))
        {
            Debug.Log($"[BuildValidator] Scene '{scenePath}' not found in build settings. Adding it.");
            
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
        var urpAsset = GraphicsSettings.defaultRenderPipeline;
        if (urpAsset == null)
        {
            Debug.LogWarning("[BuildValidator] URP Asset not assigned! Build may fail at runtime.");
        }
        else
        {
            Debug.Log($"[BuildValidator] URP Asset found: {urpAsset.name}");
        }
    }
    
    private static bool HasCompileErrors()
    {
        // В headless режиме EditorApplication.isCompiling может быть неточным.
        // Проверяем логи на наличие ошибок компиляции.
        var logs = UnityEngine.Debug.unityLogger;
        // Альтернативно: принудительная компиляция через AssetDatabase.Refresh
        AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);
        
        // Проверяем статус компиляции
        if (EditorApplication.isCompiling)
        {
            Debug.Log("[BuildValidator] Waiting for compilation...");
            // В CI ожидание может быть проблемой; лучше вернуть ошибку
            return true;
        }
        
        return false;
    }

    private static void PerformActualBuild()
    {
        string[] scenes = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
        
        if (scenes.Length == 0)
        {
            Debug.LogError("[BuildValidator] No scenes enabled in build settings! Aborting.");
            EditorApplication.Exit(1);
            return;
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = OUTPUT_PATH,
            target = BuildTarget.StandaloneWindows64,
            targetGroup = BuildTargetGroup.Standalone,
            options = BuildOptions.None
        };

        Debug.Log("[BuildValidator] Starting build process...");
        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        
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
}
