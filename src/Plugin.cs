using UnityEngine;
using MergeExample;
using UnityEngine.SceneManagement;

public class Plugin
{
    private static void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        var gameObject = new GameObject("PinkCute", typeof(PinkCute));
    }

    public static void Init()
    {
        Debug.Log("Initializing PinkCute");
        SceneManager.sceneLoaded += OnSceneLoad;
    }
}