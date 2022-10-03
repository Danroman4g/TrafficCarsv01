using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerksSystem : MonoBehaviour
{
    public Transform[] PerkZones;
    public Transform perkZone;
    public static bool canSpawn;
    private GameObject newTrigger;
    public GameObject _trigger;
    public static bool onepicked = false;
    private int healthcoast;


    private float maxX;
    private float minX;
    private float maxZ;
    private float minZ;


    void Start()
    {
        perkZone = PerkZones[Random.Range(0, PerkZones.Length)];

        maxX = perkZone.position.x + perkZone.localScale.x / 2;
        minX = perkZone.position.x - perkZone.localScale.x / 2;

        maxZ = perkZone.position.z + perkZone.localScale.z / 2;
        minZ = perkZone.position.z - perkZone.localScale.z / 2;


        canSpawn = true;
    }


    private void PointSpawner()
    {
        Vector3 spawnPOs = new Vector3(Random.Range(minX, maxX), perkZone.position.y, Random.Range(minZ, maxZ));
        newTrigger = Instantiate(_trigger, spawnPOs, Quaternion.identity);
        //print("PointSpawnerisActive");
        //print("_trigger is a " + _trigger +newTrigger);

    }

    // Update is called once per frame
    void Update()
    {

        if (onepicked == true)
        {
            canSpawn = true;
        }
        if (canSpawn)
        {
            for (int i=0; i < 3; i++)
            {
                print(i);
                PointSpawner();
                healthcoast++;
            }
            if (healthcoast > 3) canSpawn = false;

            canSpawn = false;
            gameObject.SetActive(true);

        }


        if (_trigger == null || newTrigger == null)
        {
            //Debug.Log("destroer initializated" );
            canSpawn = true;

        }
    }
}
