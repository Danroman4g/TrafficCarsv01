using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CARCONTROLLER : MonoBehaviour
{
    public WheelCollider frontLeftWheel;
    public WheelCollider frontRightWheel;
    public WheelCollider backLeftWheel;
    public WheelCollider backRightWheel;
    private float verticalInput;
    public float horizontalinput;
    public float EnginePower = 1000;
    private bool isBreaking = false;
    public float breackSense = -1500;
    public float steerangle;
    public float maxSteeringAngle;
    //  public float angle;    // assign correct angle in the inspector (90°)

    //void Awake()
    // {
    //    frontLeftWheel.steerAngle = angle;
    // frontRightWheel.steerAngle = angle;
    // backLeftWheel.steerAngle = angle;
    // backRightWheel.steerAngle = angle;
    // }



    private void Start()
    {
        isBreaking = false;
    }


    private void FixedUpdate()
    {
        carInput();
        Handlemotor();
        Steering();

    }


    private void carInput()
    {
        
        verticalInput = Input.GetAxis("Vertical");
        horizontalinput = Input.GetAxis("Horizontal");


        if (Input.GetKey(KeyCode.Space))
        {
            isBreaking = true;
        }
        else
        {
            isBreaking = false;
        }


    }


    private void Handlemotor()
    {
       
        frontLeftWheel.motorTorque = EnginePower * verticalInput;
        frontRightWheel.motorTorque = EnginePower * verticalInput;
        if (isBreaking)
        {
            frontLeftWheel.motorTorque = EnginePower * breackSense;
            frontRightWheel.motorTorque = EnginePower * breackSense;
        }
    }

    private void Steering()
    {
        frontLeftWheel.steerAngle = maxSteeringAngle * horizontalinput;
        frontLeftWheel.steerAngle = maxSteeringAngle * horizontalinput;

    }
}
