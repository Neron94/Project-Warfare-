using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {

    public int speed = 10;
    private int rotationspeed;
    private Vector3 positionOfTank;
    public int turnSpeed = 30;
    public Vector3 moveTar;
    public GameObject tower;
    public Vector3 targMouse;
   
   

    
	
	void Update () {




        float Yaxis = Input.mousePosition.y;
        targMouse.y = Yaxis;
        

        if (tower.transform.rotation.y > Yaxis)
        {
            tower.transform.rotation = Quaternion.Lerp(transform.rotation, targMouse, turnSpeed * Time.deltaTime);
        }
        if (tower.transform.rotation.y < Yaxis)
        {
            tower.transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime);
        }
       

            
 
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
