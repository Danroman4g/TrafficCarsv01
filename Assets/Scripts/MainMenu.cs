using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void GameStarter()
    {
        SceneManager.LoadScene("TrafficCarsGame");
    }

    public void SecondLevel()
    {
        SceneManager.LoadScene("TrafficCarsGameFirstlevel");
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
