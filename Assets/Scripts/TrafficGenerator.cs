using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficGenerator : MonoBehaviour
{
   public GameObject escapest;
   //[SerializeField] private _targetmove;

        public void Destroyer()
        {
            Debug.Log("QUITOFFIELD SECOND");
            Destroy(escapest.gameObject);
    }

}
