using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public GameObject _trigger;
    public Transform spawnZone;
    private bool canSpawn;
    private GameObject newTrigger;
    public Transform[] SpawnZones;//= GameObject.FindGameObjectsWithTag("SpawnPointZone");




    private float maxX;
    private float minX;
    private float maxZ;
    private float minZ;


  

        private void Start()
    {


        spawnZone = SpawnZones[Random.Range(0, SpawnZones.Length)];

        maxX = spawnZone.position.x + spawnZone.localScale.x / 2;
        minX = spawnZone.position.x - spawnZone.localScale.x / 2;

        maxZ = spawnZone.position.z + spawnZone.localScale.z / 2;
        minZ = spawnZone.position.z - spawnZone.localScale.z / 2;

        

        canSpawn = true;
    }

    /* public void Spawn()
     {
         Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
         Instantiate(kub, pos, Quaternion.identity); // осуществляем появление объекта в заданных случайных позициях в диапазоне заданных координат

         Vector3 pos2 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
         Instantiate(sphere, pos2, Quaternion.identity);
     }
    */

    /*private void PosFinder()
    {
       

    }
    */

    private void PointSpawner()
    {
        Vector3 spawnPOs = new Vector3(Random.Range(minX, maxX), spawnZone.position.y, Random.Range(minZ, maxZ));
        newTrigger = Instantiate(_trigger, spawnPOs, Quaternion.identity);
       
        //print("PointSpawnerisActive");
        //print("_trigger is a " + _trigger +newTrigger);

    }


    private void FixedUpdate()
    {
        //Debug.Log("CanSpawn now is - " +canSpawn);
        if (canSpawn)
        {
            PointSpawner();
            canSpawn = false;
            gameObject.SetActive(true);
            

        }

        if(_trigger!=null) LookAtArrow.canspawn = true;

        if (_trigger==null || newTrigger == null)
        {
            //Debug.Log("destroer initializated" );
            canSpawn = true;
            LookAtArrow.canspawn = false;
            
        }

        
       
        }


    /*private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Plyer");
        {
            Pickpoint();
            print("trigger in & tag aproved");
        }
    }
    */


   /* public void Pickpoint()
    {

        Debug.Log("destroer initializated");
        Destroy(_trigger);
        canSpawn = true;


    }
   */
}
