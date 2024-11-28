using UnityEditor;using System.IO;using System.Linq;

public class Builder{
    public static void BuildWebGL()
    {
        // 빌드 설정
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = GetBuildScenes();
        buildPlayerOptions.locationPathName = "builds/WebGL";
        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.None;
        // 빌드 실행
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
    private static string[] GetBuildScenes()
    {
        return EditorBuildSettings.scenes
        .Where(scene => scene.enabled)
        .Select(scene => scene.path)
        .ToArray();
    }}