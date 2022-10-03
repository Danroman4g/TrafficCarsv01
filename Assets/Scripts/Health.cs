using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //public float health = 100;
    
    public Image healthbar;
    public static float health, maxhealth = 100;
   // public static float maxhealth = 100;
    //public static float damage;
    float lerpspeed;

    //public Text healthtext;


    void Start()
    {
        health = maxhealth;
        //damage = 0;

        
       
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            print("Health is over");
            DeadController();
        }

            print("health :" + health);

        //healthtext.text = health + "%";
        lerpspeed = 3f * Time.deltaTime;
       // print(damage);
        /* if (damage > 1)
         {
             print("damage");
             health -= damage;
        }*/
        if (health > maxhealth) health = maxhealth;
        HealthBarFiller();
        ColorChanger();

    }

   

    public void ColorChanger()
    {
        Color healthcolor = Color.Lerp(Color.red, Color.green, (health / maxhealth)) ;
        healthbar.canvasRenderer.SetAlpha(0.5f);
        healthbar.color = healthcolor;


    }



    private void HealthBarFiller()
    {
        healthbar.fillAmount = Mathf.Lerp(healthbar.fillAmount, health / maxhealth, lerpspeed);

    }
    public static void DamagePoints(float damagePoints)
    {
        if (health > 0)
        {
            //damagePoints = damage;
            //print("damagepoints is" + damagePoints);
            health -= damagePoints;
        }
    }

    public static void Heal (float healpoints)
        {
            if (health < maxhealth)
                health += healpoints;
        }
    private void DeadController()
    {
        print("END GAME IS " + GameManager1.endgame);
            GameManager1.endgame = true;

        
        
    }


    }




