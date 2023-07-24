using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void LoadScene() 
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
}