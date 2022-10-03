using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FinalScreen : MonoBehaviour
{
    private int finalscore;
    public Text pointsText;
    public AudioSource finalsound;
    public AudioSource click;
   // private PhysicsScene 



    public void Setup()
    {
        finalscore = PointsDisplay.scorevalue;
        gameObject.SetActive(true);
        finalsound.Play();
        pointsText.text = "CASH- " + finalscore.ToString();
    }

    public void ResetButton()
    {
        print("reset");
        click.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameObject.SetActive(false);
        Timer.osttime = 40;
        Health.health = 100;
        PointsDisplay.scorevalue = 0;

    }

    public void MainMenu()
    {
        click.Play();
        SceneManager.LoadScene("MainMenu");
    }
}
