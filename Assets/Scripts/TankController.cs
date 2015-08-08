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
    public float skrSpeed = 4.0f; 
	public GameObject gun;
	public float deadzone = 20;
	public GameObject rayer;
	public int range=1000;
    public GameObject camera;
    public GameObject secondCamera;
    public int caseswitcher = 1;
    public AudioClip shot;
    
    
    
    


    void Start()
    {
        Cursor.visible = false;
        secondCamera.SetActive(false);

    }
   
	void Update () {

        

		if(Input.GetMouseButtonDown(0))
		{
            AudioSource audio;
            audio = GetComponent<AudioSource>();
            audio.PlayOneShot(shot);
            
			Vector3 direction = rayer.transform.TransformDirection(Vector3.forward);
			RaycastHit hit;
			Debug.DrawRay(rayer.transform.position, direction, Color.yellow);
			if (Physics.Raycast(rayer.transform.position, direction, out hit , range)){

				if(hit.collider.gameObject.tag ==("Enemy"))
				{
					Destroy(hit.collider.gameObject);
					Debug.Log("Enemy Down");
                    
				}
			}
		}


		                                  // БЛОК УПРАВЛЕНИЯ ВРАЩЕНИЕМ БАШНИ И ОРУДИЯ ТАНКА
        float sk = skrSpeed * Input.GetAxis("MouseScrollWheel");
		float h = horSpeed * Input.GetAxis("Mouse X");
		tower.transform.Rotate(0, 0, h);
		float v =  verSpeed * Input.GetAxis("Mouse Y");


        gun.transform.Rotate(-v, 0, 0);
        
        
        camera.transform.Translate(0, 0, sk);
        //gun.transform.localRotation.x <= deadzone
		//Debug.Log(gun.transform.rotation.x);
        if (gun.transform.rotation.x > 0.8f)
        {

            caseswitcher = 2;
        }

        if (gun.transform.rotation.x < 0.6f)
        {

            caseswitcher = 3;
        }
        

        Debug.Log(gun.transform.rotation.x);

        /*
            switch(caseswitcher)
          {
               case 1:
                   gun.transform.Rotate(-v, 0, 0);
                  break;
              case 2:
                   gun.transform.Rotate(0.79f, 0, 0);
                   break;
               case 3:
                   gun.transform.Rotate(0.61f, 0, 0);
                   break;
           }
    */


        
        
        
        if (camera.transform.localPosition.y > -8.0f)
        {
            camera.SetActive(false);
            secondCamera.SetActive(true);
            rayer = GameObject.Find("Image");
            

        }
        if (camera.transform.localPosition.y < -8.0f)
        {
            camera.SetActive(true);
            secondCamera.SetActive(false);
            rayer = GameObject.Find("Cross");


        }
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
