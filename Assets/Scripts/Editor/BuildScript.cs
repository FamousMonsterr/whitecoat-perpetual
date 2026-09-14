using System.Linq;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

/// <summary>
/// Сборка из редактора: меню Whitecoat/Build.
/// Для CI используется BuildValidator.ForceBuild.
/// </summary>
public static class BuildScript
{
    private const string OutputWin = "build/StandaloneWindows64/WhitecoatPerpetual.exe";
    private const string OutputWebGL = "build/WebGL/WhitecoatPerpetual";
    private const string OutputLinux = "build/StandaloneLinux64/WhitecoatPerpetual.x86_64";

    [MenuItem("Whitecoat/Build/Windows 64-bit", priority = 10)]
    public static void BuildWindows() => PerformBuild(BuildTarget.StandaloneWindows64, OutputWin);

    [MenuItem("Whitecoat/Build/WebGL", priority = 11)]
    public static void BuildWebGL() => PerformBuild(BuildTarget.WebGL, OutputWebGL);

    [MenuItem("Whitecoat/Build/Linux 64-bit", priority = 12)]
    public static void BuildLinux() => PerformBuild(BuildTarget.StandaloneLinux64, OutputLinux);

    public static void PerformBuild(BuildTarget target, string outputPath)
    {
        Debug.Log($"[Build] Starting {target} build...");

        // Сцена пересобирается из кода — гарантия актуальности
        SceneBuilder.EnsureBuilt(force: true);
        AssetDatabase.SaveAssets();

        string[] scenes = EditorBuildSettings.scenes
            .Where(s => s.enabled)
            .Select(s => s.path)
            .ToArray();

        if (scenes.Length == 0)
        {
            Debug.LogError("[Build] No scenes in build settings!");
            EditorApplication.Exit(1);
            return;
        }

        var options = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = outputPath,
            target = target,
            targetGroup = BuildTargetGroup.Standalone,
            options = BuildOptions.None
        };

        BuildReport report = BuildPipeline.BuildPlayer(options);

        if (report.summary.result == BuildResult.Succeeded)
        {
            Debug.Log($"[Build] Success! {target} Size: {report.summary.totalSize} bytes");
        }
        else
        {
            Debug.LogError("[Build] Failed!");
            EditorApplication.Exit(1);
        }
    }
}
