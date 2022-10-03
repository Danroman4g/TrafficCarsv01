using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CarControl : MonoBehaviour 
{
	private CarMove m_Car;
	//public Joystick Joistickhor;
	public Joystick Joistickver;


	private void Awake()
	{
		m_Car = GetComponent<CarMove>();
	}



	private void FixedUpdate()
	{
		// pass the input to the car!
		float h = Joistickver.Horizontal;
		float v = Joistickver.Vertical;
#if !MOBILE_INPUT
		float handbrake = CrossPlatformInputManager.GetAxis("Jump");
		m_Car.Move(v, v, handbrake, h);
#else
		m_Car.Move(v, v, 0f, h);
#endif
	}
}
