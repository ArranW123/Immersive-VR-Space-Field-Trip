using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelLoader : MonoBehaviour
{
    public string levelName;
    public async void NextLevel(string levelName)
    {
        var scene = SceneManager.LoadSceneAsync(levelName);
        //scene.allowSceneActivation = false;
        
    }
}