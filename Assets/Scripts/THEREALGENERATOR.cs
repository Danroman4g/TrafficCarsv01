using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THEREALGENERATOR : MonoBehaviour
{
    public GameObject[] _trafficcars;
    private GameObject currentcar;
    public GameObject _startpoint;
    public GameObject _endpoint;
    public float speed = 30;
    public bool isout;
    public bool canspawn;



    public void CarSpawner()
    {


       currentcar = Instantiate(_trafficcars[Random.Range(0, _trafficcars.Length)], _startpoint.transform.position, _startpoint.transform.rotation);
       // Debug.Log("Машина появилась здесь-" +currentcar.transform.position);

        //currentcar.transform.position = _startpoint.transform.position;
    }

    public void Go()

    {
        //Debug.Log("Car is " + currentcar);
        //Debug.Log("Go to :" + _endpoint.transform.position); new Vector3
        currentcar.transform.position = Vector3.MoveTowards(currentcar.transform.position,_endpoint.transform.position, Time.deltaTime * speed);
        //currentcar.transform.position = Vector3.MoveTowards(transform.position, new Vector3(72.3f, 0.4f), Time.deltaTime*speed);
    }


    public void Guardian()
    {
        isout = true;

    }

    private void Start()
    {
        canspawn = true;
        isout = false;
        //Debug.Log("Машина должна пояявится здесь" +_startpoint.transform.position);
    }


    private void Update()

    {

        if (canspawn)
        {
            CarSpawner();  // обращаюсь к функции создания экземпляров префаба из массива
            canspawn = false; //создали? Больше пока не создаём

        } //обращаюсь к функции движении созданного экземпляра
        //Debug.Log("togo");
        Go();
        if (isout)  //Обращаюсь к переменной, отвечающей за выход экземпляра за границы видимости
        {
            Destroy(currentcar.gameObject); //удаляю отживший свой не лёгкий путь экземпляр
            isout = false;          //удалили? больше пока не удаляем.
            canspawn = true;        // можно создавать по новой. 
        }





    }
}