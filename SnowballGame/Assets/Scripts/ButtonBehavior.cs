using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    
    // M E T H O D S
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void ShowInstructions()
    {
        SceneManager.LoadScene("HowToPlayScene");
    }
    public void ShowStartScreen()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void ShowEndScreen()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
