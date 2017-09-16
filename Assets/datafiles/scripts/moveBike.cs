using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBike : MonoBehaviour {

	public float speed = 10f;
	public float scale = 0.2f;
	public GameObject Bike;

	Camera cam;

	float prevAngle;
	bool stopBike = false;

	// Use this for initialization
	void Start () {
		cam = GetComponentInChildren<Camera>();
		prevAngle = cam.transform.rotation.eulerAngles.y;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//transform.position = Bike.transform.position + (Bike.transform.right - new Vector3 (scale, 0, 0)) + (Bike.transform.up);

		Bike.transform.RotateAround (transform.position, Bike.transform.up, cam.transform.rotation.eulerAngles.y - prevAngle);

		// Right now the bike rotates along camera's axis, so it's not as realistic.
		// Need to add in bike's own rotation depending on whether you're going left or right
		//		if (cam.transform.rotation.eulerAngles.y - prevAngle > 0) {
		//			// rotating right
		//			Bike.transform.rotation.x = Bike.transform.rotation.x + 10;
		//		} else if (cam.transform.rotation.eulerAngles.y - prevAngle < 0) {
		//			Bike.transform.rotation.x = Bike.transform.rotation.x - 10;
		//		} else {
		//			Bike.transform.rotation.x = Bike.transform.rotation.x;
		//
		//		}
		//Bike.transform.rotation = cam.transform.rotation * Quaternion.Euler(0, 90, 0);

		if (Input.GetButton ("Fire1") && !stopBike) {
		// go forward
			// when bike is hitting a wall, 
			// bike's not gonna move but since we're changing transform
			// it's gonna be off.... need to take care of that 
			transform.position = transform.position + cam.transform.forward * Time.deltaTime * speed;

		} 
		prevAngle = cam.transform.rotation.eulerAngles.y;


		//transform.rotation = Quaternion.Lerp(transform.localRotation, cam.transform.localRotation, speed);
	}


	public void StopBike () {
		stopBike = true;
	}
	
}
