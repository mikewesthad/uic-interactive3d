using UnityEngine;
using System.Collections;

public class FlyControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// WARNING: this is not the way to handle rotating around two axes! This
		// demo shows what can go wrong (e.g. gimbal lock)

		Debug.Log("Mouse X: " + Input.GetAxis("Mouse X"));
		Debug.Log("Mouse Y: " + Input.GetAxis("Mouse Y"));

		// The mouse x movement should turn the camera left/right. This is a 
		// rotation around the y-axis.
		float mouseX = Input.GetAxis("Mouse X");
		transform.Rotate(0f, mouseX, 0f);

		// The mouse y movement should turn the camera up/down. This is a 
		// rotation around the x-axis. Note: the mouse y value needs to be 
		// inverted.
		float mouseY = Input.GetAxis("Mouse Y");
		transform.Rotate(-mouseY, 0f, 0f);
	}
}
