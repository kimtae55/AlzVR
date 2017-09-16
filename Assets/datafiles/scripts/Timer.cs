using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
	public float bestTime;
	public  float timeRemain;
	public  TextMesh timer;

	bool reached = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!reached) {
			timeRemain = timeRemain + Time.deltaTime;
			timer.text = timeRemain.ToString ("F2");
		}
	}

	public void StopTimer() {
		bestTime = timeRemain;
		timer.text = bestTime.ToString("F2");
		reached = true;
	}
}
