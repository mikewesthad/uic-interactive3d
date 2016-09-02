using UnityEngine;
using System.Collections;

public class ManipulatingTransform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Translating and rotating ONCE when the app is run:
		// transform.Translate(3f, 5f, 0f);
		// transform.Rotate(45f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		// Rotating a small amount each frame
		// Time.deltaTime = Seconds since the last frame
		float speed = 360f; // Degrees per second
		transform.Rotate(0f, speed * Time.deltaTime, 0f);
	}
}
