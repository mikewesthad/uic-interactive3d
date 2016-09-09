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
		// Using quaternions
		RotationX += -Input.GetAxis("Mouse Y") * MouseSensitivityY;
		RotationY += Input.GetAxis("Mouse X") * MouseSensitivityX;
		transform.localRotation = Quaternion.Euler(RotationX, RotationY, 0f);

		// Moving forward & backward
		if (Input.GetKey("w")) {
			transform.Translate(0f, 0f, Speed * Time.deltaTime);
		} else if (Input.GetKey("s")) {
			transform.Translate(0f, 0f, -Speed * Time.deltaTime);
		}
	}
}
