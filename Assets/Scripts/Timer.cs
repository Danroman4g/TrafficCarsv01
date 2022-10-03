using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public static float osttime = 40;
    Text timer;


    void Start()
    {
        timer = GetComponent<Text>();

    }

    void Update()
    {
        osttime -= Time.deltaTime;
        timer.text = "Timer:" + Mathf.Round(osttime).ToString();

        if (osttime <= 0) GameManager1.endgame = true;
    }
}
