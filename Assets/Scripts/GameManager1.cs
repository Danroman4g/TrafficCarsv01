using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    public static bool endgame;
    public FinalScreen FinalScreen;
    private float count=2;

    private void Start()
    {
        //print("start");
        endgame = false;
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        //print("GAME OVER GAME OVER GAME OVER");
        FinalScreen.Setup();
        count -= Time.deltaTime;
        if (count<=0) Time.timeScale = 0;


    }


    public void Update()
    {
        if (endgame) EndGame();
        
    }

}
