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

        float y = Input.mousePosition.y;
        targMouse = new Vector3(0, y, 0);

            

            if (true)
            {
                tower.transform.LookAt(targMouse);
            }
            else { }

        
        
        
        
        
        
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
