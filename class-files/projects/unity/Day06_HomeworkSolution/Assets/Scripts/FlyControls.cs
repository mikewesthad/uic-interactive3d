using UnityEngine;
using System.Collections;

public class FlyControls : MonoBehaviour {

	public float Speed = 3f;
	public float MouseSensitivityX = 1f; 
	public float MouseSensitivityY = 1f; 

	private float RotationX = 0F;
	private float RotationY = 0F;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Rotation with quaternions
		RotationX += -Input.GetAxis("Mouse Y") * MouseSensitivityY;
		RotationY += Input.GetAxis("Mouse X") * MouseSensitivityX;
		transform.localRotation = Quaternion.Euler(RotationX, RotationY, 0f);

		// Double the Speed when left shift is held down
		float movement = Speed * Time.deltaTime;
		if (Input.GetKey("left shift")) {
			movement = 2f * Speed * Time.deltaTime;
		}

		// Moving forward & backward
		if (Input.GetKey("w")) {
			transform.Translate(0f, 0f, movement);
		} else if (Input.GetKey("s")) {
			transform.Translate(0f, 0f, -movement);
		}

		// Strafing
		if (Input.GetKey("a")) {
			transform.Translate(-movement, 0f, 0f);
		} else if (Input.GetKey("d")) {
			transform.Translate(movement, 0f, 0f);
		}

		// Vertical movement
		if (Input.GetKey("e")) {
			transform.Translate(0f, movement, 0);
		} else if (Input.GetKey("q")) {
			transform.Translate(0f, -movement, 0f);
		}
	}
}
