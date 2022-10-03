using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTriggerManager : MonoBehaviour
{
    public int points;
    


    private int tax;
    private int addedTime;
    private float getdamage;
    public AudioSource crushsound;
    public AudioSource pointPeak;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {

            Destroy(other.gameObject);
            points++;
            pointPeak.Play();

            //print("У вас " + points +"очков");
            tax = Random.Range(10, 150);
            addedTime = tax / 4;
            Timer.osttime += addedTime;
            //print("Доп время " +addedTime);
            MomentPointDisplay.plusscore = tax;
            PointsDisplay.scorevalue += tax;
            //LookAtArrow.pointpicked = true;


        }


        if (other.gameObject.tag == "Health")
        {

            Destroy(other.gameObject);

            PerksSystem.onepicked = true;
            Health.Heal(25);

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "TrafficCars"|| collision.gameObject.tag == "Car")
        {
            crushsound.Play();
            getdamage = Random.Range(5, 50);
            Health.DamagePoints(getdamage);//Health.damage = getdamage;
            //print("Damage from" + collision.gameObject+" in count  "+getdamage);
        }
    }
}
