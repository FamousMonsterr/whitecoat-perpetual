using UnityEditor;
using System.Linq;
using UnityEngine;
using UnityEditor.Build.Reporting;

public class BuildScript
{
    public static void PerformBuild()
    {
        Debug.Log("[Build] Starting Unity 6 Build Process...");
        
        // В Unity 6 рекомендуется использовать BuildProfiles, но для CLI пока поддерживаем классический метод
        // с явным указанием целевой платформы и группы.
        string[] scenes = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
        
        if (scenes.Length == 0) 
        {
            Debug.LogWarning("[Build] No scenes found in Build Settings. Adding Main.unity");
            scenes = new[] { "Assets/Scenes/Main.unity" };
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = "Builds/Windows/WhitecoatPerpetual.exe",
            target = BuildTarget.StandaloneWindows64,
            targetGroup = BuildTargetGroup.Standalone,
            // В Unity 6 IL2CPP по умолчанию для Windows, но явно укажем для надежности
            subtarget = (int)StandaloneBuildSubtarget.Player, 
            options = BuildOptions.None
        };

        // Проверка на наличие ошибок компиляции перед стартом
        if (EditorApplication.isCompiling)
        {
            Debug.Log("[Build] Waiting for compilation to finish...");
            return; 
        }

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        
        if (report.summary.result == BuildResult.Succeeded)
        {
            Debug.Log($"[Build] Success! Size: {report.summary.totalSize} bytes");
        }
        else if (report.summary.result == BuildResult.Failed)
        {
            Debug.LogError("[Build] Build failed with errors.");
            throw new System.Exception("Build failed");
        }
    }
}
