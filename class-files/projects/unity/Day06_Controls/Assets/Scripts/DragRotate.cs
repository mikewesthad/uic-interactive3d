using UnityEngine;
using System.Collections;

public class DragRotate : MonoBehaviour {

	public float MouseSensitivity = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDrag() {
		float dragAmount = -Input.GetAxis("Mouse X") * MouseSensitivity;
		transform.Rotate(0f, dragAmount, 0f);
	}
}
