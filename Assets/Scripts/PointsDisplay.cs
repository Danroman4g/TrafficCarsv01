using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsDisplay : MonoBehaviour
{
    public static int scorevalue=0;
    Text score;


    private void Start()
    {
        score = GetComponent<Text>();
      
    }



    private void Update()
    {
        score.text = "Score  " + scorevalue;
    }

    
}
