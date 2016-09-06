using UnityEngine;
using System.Collections;

public class Transformer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 2f; // Meters per second
		float xMovement = speed * Time.deltaTime; // Meters moved in a frame
		transform.Translate(xMovement, 0f, 0f);

		float rotationSpeed = 45f; // Degrees per second
		float xRotation = rotationSpeed * Time.deltaTime; // Degrees moved in a frame
		transform.Rotate(xRotation, 0f, 0f);
	}
}
