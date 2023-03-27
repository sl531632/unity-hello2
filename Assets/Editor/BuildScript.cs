using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuildScript  
{
#if UNITY_EDITOR

    public static void BuildAndroid()
    {
        string[] scenes = { "Assets/Scenes/SampleScene.unity"}; 
        string outputPath = "xd-game-hello2.apk";  
        BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.Android, BuildOptions.None);
    }
#endif

}
