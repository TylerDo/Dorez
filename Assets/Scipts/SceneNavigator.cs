using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    //Serialize field allows us to have the variable show up in the editor
    //But also keep the variable private
    [SerializeField] int SceneIndex;
    //Loads scene by SceneIndex
    public void LoadScene()
    {
        if(SceneIndex < SceneManager.sceneCountInBuildSettings == true)//If index is within scene count
        {
            SceneManager.LoadScene(SceneIndex);
            Debug.Log("Loading Scene: " + SceneIndex.ToString());
        }
        else
        {
            Debug.Log("Scene index doesn't exist.");
        }
    }
    //Quits Application
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting application.");
    }
}
