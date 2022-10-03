using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtArrow : MonoBehaviour
{
    private Transform target;
    public float waittime;
    public float waittime2;

    public static bool canspawn = false;
    public static bool pointpicked = false;
    public bool wait;

    // Start is called before the first frame update
    void Start()
    {

        wait = false;

        Coldown();
        waittime = 3;
        waittime2 = 3;


    }


    private void Coldown()
    {
        print("Coldown time is  : " + waittime);
        //waittime -= Time.deltaTime;
        wait = true;


    }


   /* private void Targetfinder()
    {
       
       target = GameObject.FindGameObjectWithTag("Point").transform;
    }
   */



    private void FixedUpdate()
    {

        //print("Coldown time is  : " + waittime)
            
            target = GameObject.FindGameObjectWithTag("Point").transform;
           
               
            transform.LookAt(target);
          
        
       





    }
}


/*  if (target==null)
        {

           // Coldown();
                if (wait==true)
                {
                    target = GameObject.FindGameObjectWithTag("Point").transform;
                    wait = false;
                }
        }
        

    }






    // Update is called once per frame
    /* void Update()
     {
         print(canspawn);

         waittime -= Time.deltaTime;

         if (target = null)
         {
             waittime -= Time.deltaTime;
             if (waittime <= 0)
             {
                 canspawn = true;
             }
         }
         if (canspawn==true)
         {
             pointpicked = false;
             Targetfinder();
             transform.LookAt(target);
         }


         if (pointpicked == true)
         {
             canspawn = false;
             waittime2 -= Time.deltaTime;
             if (waittime2 <= 0)
             {
                 canspawn = true;
             }
            }
          }
          */

        

