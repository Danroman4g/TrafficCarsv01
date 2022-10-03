using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerv4 : MonoBehaviour
{
    public WheelCollider frontLeftWheel, frontRightWheel;
    public WheelCollider rearLeftWheel, rearRightWheel;
    public Transform frontLeftWheelModel, frontRightWheelModel;
    public Transform rearLeftWheelModel, rearRightWheelModel;
    public GameObject PlayerCar;
    public bool useCustomCenterOfMass = false;
    public Vector3 centerOfMassOffset;


    private float m_horizontallinput;
    private float m_verticalinput;
    private float m_steeringAngle;
    //public float m_space;

    public float motorforce = 1300;
    public float maxsteeringangle = 30;
    public float maxBrake = 100;



    private void GetInput()
    {
        m_horizontallinput = Input.GetAxis("Horizontal");
        m_verticalinput = Input.GetAxis("Vertical");
 
    }

    private void Steer()
    {
        m_steeringAngle = maxsteeringangle * m_horizontallinput;
        frontLeftWheel.steerAngle = m_steeringAngle;
        frontRightWheel.steerAngle = m_steeringAngle;
    }

    private void Accelerate()
    {
        frontLeftWheel.motorTorque = motorforce * m_verticalinput;
        frontRightWheel.motorTorque = motorforce * m_verticalinput;
    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(frontLeftWheel, frontLeftWheelModel);
        UpdateWheelPose(frontRightWheel, frontRightWheelModel);
        UpdateWheelPose(rearLeftWheel, rearLeftWheelModel);
        UpdateWheelPose(rearRightWheel, rearRightWheelModel);

    }

    private void UpdateWheelPose(WheelCollider _collider, Transform _transform)
    {
        Vector3 _pos = _transform.position;
        Quaternion _qua = _transform.rotation;
        _collider.GetWorldPose(out _pos, out _qua);

        _transform.position = _pos;
        _transform.rotation = _qua;

    }

    private void Brake()
    {
        print("Brake");
        frontLeftWheel.brakeTorque = maxBrake;
        frontRightWheel.brakeTorque = maxBrake;
    }
    private void ResetCar()
    {
        PlayerCar.transform.position = transform.TransformPoint(0f, 2f, -10f);
        PlayerCar.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    

    private void Update()
    {
      if (Input.GetKey(KeyCode.Space)) Brake();
       // else return;
      if (Input.GetKey(KeyCode.R)) ResetCar();
      if (PlayerCar.transform.rotation.x > 90) ResetCar();
        GetInput();
        Steer();
        Accelerate();
        UpdateWheelPoses();

    }

    private void CheckCenterOfMass()
    {
        if (useCustomCenterOfMass)
        {
            GetComponent<Rigidbody>().centerOfMass = centerOfMassOffset;
        }
    }

#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        CheckCenterOfMass();
    }
#endif
 
}
