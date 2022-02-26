using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMenu : MonoBehaviour
{
    public void PlayGame(int sceneIndex)
    {
        if (sceneIndex > SceneManager.sceneCountInBuildSettings)
        {
            return;
        }

        SceneManager.LoadSceneAsync(sceneIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
