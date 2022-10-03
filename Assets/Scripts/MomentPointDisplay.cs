using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MomentPointDisplay : MonoBehaviour
{
    public static int plusscore = 0;
    Text plus;
    public static bool scored;
    private float timeRemaining = 2;



    private void Fadein()
    {
        plus.CrossFadeAlpha(1, 2, false);
    }

    private void FadeOut()
    {
        plus.CrossFadeAlpha(0, 2, false);

    }


    void Start()
    {
        //FadeOut();
        //plus.canvasRenderer.SetAlpha(1);
        plus = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (plusscore > 0)
        {
            //print("Scored is- " + scored + ". Your tax is-  " + plusscore + ". Time remaning is- " + timeRemaining +"sec.");
            scored = true;
            if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                    //print("Time remaning" +timeRemaining);
                }

            else
            {
                timeRemaining += 2;
                scored = false;
                plusscore = 0;
                //print("Scored is- " + scored + ". Your tax is-  " + plusscore + ". Time remaning is- " + timeRemaining + "sec.");
            }

            
        }


        if (scored)
        {

            Fadein();
            plus.text = "+ " +plusscore;
            FadeOut();
        }

    }
}
