using UnityEngine;
using System.Collections;

public class MouseInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Whenever the mouse is over the collider attached to this game object, 
	// OnMouseOver is invoked.
	void OnMouseOver() {
		float rotationSpeed = 360f; // Degrees per second
		float rotationAmount = rotationSpeed * Time.deltaTime;
		transform.Rotate(0f, rotationAmount, 0f);
	}

	// Whenever the mouse is pressed while over the collider, OnMouseDown is 
	// called.
	void OnMouseDown() {
		transform.Translate(1f, 0f, 0f);
		// Note, you can't just run both the rotation and the translate code 
		// together. By default, transform.Translate operates on Space.Self 
		// (local coordinates). Any rotation will change what direction the
		// x-axis points in.
	}
}
