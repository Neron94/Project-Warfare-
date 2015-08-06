using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {

    public int speed = 3;
    private int rotationspeed;
    private Vector3 positionOfTank;
    public int turnSpeed = 3;
    public Vector3 moveTar;
    public GameObject tower;
	public float horSpeed = 4.0f; 
	public float verSpeed = 4.0f; 
	public GameObject gun;
	public float deadzone = 20;
	public GameObject rayer;
	public int range=1000;


   
	void Update () {


		if(Input.GetMouseButton(0))
		{
			Vector3 direction = rayer.transform.TransformDirection(Vector3.up);
			RaycastHit hit;
			Debug.DrawRay(rayer.transform.position, direction, Color.yellow);
			if (Physics.Raycast(rayer.transform.position, direction, out hit , range)){

				if(hit.collider.gameObject.name==("Enemy"))
				{
					Destroy(hit.collider.gameObject);
					Debug.Log("Destroy");
				}
			}
		}


		                                  // БЛОК УПРАВЛЕНИЯ ВРАЩЕНИЕМ БАШНИ И ОРУДИЯ ТАНКА

		float h = horSpeed * Input.GetAxis("Mouse X");
		tower.transform.Rotate(0, 0, h);
		float v =  verSpeed * Input.GetAxis("Mouse Y");
		gun.transform.Rotate(-v,0,0);
        //gun.transform.localRotation.x <= deadzone
		//Debug.Log(gun.transform.rotation.x);
		if(gun.transform.rotation.x > deadzone)
		{
			Debug.Log("Papa.");
		}
	

		                                 // БЛОК УПРАВЛЕНИЯ КОРПУСОМ ТАНКА

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward *speed* Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime);
        }

		                                                   




	}
}
