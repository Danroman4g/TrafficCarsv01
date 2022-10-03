using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic : MonoBehaviour
{
    public GameObject endpoint;//GameObject.Find("finalpoint");
    public float speed = 30;
    public Transform _startpoint;
    public Transform[] trafficpoints;


    //FindObjectsOfType(typeof(твой_класс)) as твой_класс[];

    private void Start()
    {
        
    }

    private void Update()
    {

       //transform.position = Vector3.MoveTowards(transform.position, endpoint.transform.position, Time.deltaTime * speed);

    }

}
