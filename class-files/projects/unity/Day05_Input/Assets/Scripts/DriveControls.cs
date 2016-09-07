using UnityEngine;
using System.Collections;

public class DriveControls : MonoBehaviour {

	// These variables are called "fields". They can be accessed from anywhere 
	// inside of this file (e.g. in Start or in Update). The public keyword 
	// makes them show up as variables in the inspector.
	public float Speed; // Meters per second
	public float TurnSpeed; // Degrees per second

	// Use this for initialization
	void Start () {
		Debug.Log("Speed is: " + Speed);
	}
	
	// Update is called once per frame
	void Update () {
		// Forward/backward movement
		if (Input.GetKey("w")) {
			transform.Translate(0f, 0f, Speed * Time.deltaTime);
		} else if (Input.GetKey("s")) {
			transform.Translate(0f, 0f, -Speed * Time.deltaTime);
		} 

		// Left/right turning
		if (Input.GetKey("a")) {
			transform.Rotate(0f, -TurnSpeed * Time.deltaTime, 0f);
		} else if (Input.GetKey("d")) {
			transform.Rotate(0f, TurnSpeed * Time.deltaTime, 0f);
		}

		// Note: we used two separate if statements here, because we want to be
		// able to BOTH move forward and turn at the same time.
	}
}
