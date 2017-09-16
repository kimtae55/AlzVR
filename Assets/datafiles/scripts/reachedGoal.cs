using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reachedGoal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter (Collider collide) {
		
		if (collide.gameObject.CompareTag("GasStation")) {
			GameObject.Find("TimerObj").SendMessage ("StopTimer");
			GameObject.Find("Camera").SendMessage("StopBike");
			// make a menu interface that shows 
			//bestTime = Timer.timeRemain;
			//Timer.timer.text = bestTime.ToString("F2");
		}
	}
}
