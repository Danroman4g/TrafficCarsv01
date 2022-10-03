using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointCollect : MonoBehaviour
{

    public bool picked;

    private void Start()
    {
       picked= false;
    }

    private void Update()
    {
        if (picked)
        {
            print("Picked");
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
