using UnityEditor;
using System.Linq;
using UnityEngine;
using UnityEditor.Build.Reporting;

/// <summary>
/// Скрипт сборки для ручного запуска из Unity Editor.
/// Для CI/CD используется BuildValidator.ForceBuild.
/// </summary>
public class BuildScript
{
    private const string OUTPUT_PATH = "build/StandaloneWindows64/WhitecoatPerpetual.exe";

    [MenuItem("Build/Windows Build")]
    public static void PerformBuild()
    {
        Debug.Log("[Build] Starting Unity 6 Build Process...");
        
        string[] scenes = EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
        
        if (scenes.Length == 0) 
        {
            Debug.LogWarning("[Build] No scenes found in Build Settings. Adding Main.unity");
            scenes = new[] { "Assets/Scenes/Main.unity" };
        }

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = OUTPUT_PATH,
            target = BuildTarget.StandaloneWindows64,
            targetGroup = BuildTargetGroup.Standalone,
            subtarget = (int)StandaloneBuildSubtarget.Player, 
            options = BuildOptions.None
        };

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        
        if (report.summary.result == BuildResult.Succeeded)
        {
            Debug.Log($"[Build] Success! Size: {report.summary.totalSize} bytes");
        }
        else if (report.summary.result == BuildResult.Failed)
        {
            Debug.LogError("[Build] Build failed with errors.");
        }
    }
}
