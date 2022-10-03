using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class Reset : MonoBehaviour
{

    [SerializeField] private UnityEvent _out = new UnityEvent();
    [SerializeField] private bool isOut;

    public event UnityAction Out
    {
        add => _out.AddListener(value);
        remove => _out.RemoveListener(value);
    }



    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("INMHEE");

    }

    private void OnTriggerExit(Collider other)
    {

        //Debug.Log("QUITOFFIELD");
        _out.Invoke();
        if (other.gameObject.tag == "Player") GameManager1.endgame = true;
       
            


        //Destroy(other.gameObject);

        
    }
}
