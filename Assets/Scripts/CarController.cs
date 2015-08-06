using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

	public WheelCollider [] ForwardWC;
	public WheelCollider [] BackWC;
	
	public float maxSteer = 30;
	public float maxAccel = 25;
	public float maxBrake = 50;
	public float speed = 50;
	
	
	void Start () {
	
	}
	
	void FixedUpdate () {
		float accel = 0;
		float steer = 0;
		
		accel = speed*Input.GetAxis("Vertical");
		steer = Input.GetAxis("Horizontal");
		
		CarMove(accel, steer);
	
	}
	private void CarMove(float accel, float steer)
	{
		foreach(WheelCollider col in ForwardWC)
		{
			col.steerAngle = steer*maxSteer;
		}
		
		if (accel == 0){
			foreach(WheelCollider col in BackWC)
			{
				col.brakeTorque = maxBrake;
			}
		}
		
		foreach(WheelCollider col in BackWC){
			col.brakeTorque = 0;
			col.motorTorque = accel*maxAccel;
		}
	}
}
