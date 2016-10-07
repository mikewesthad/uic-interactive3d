using UnityEngine;
using System.Collections;

public class LogicalOperators : MonoBehaviour {

	private Camera Cam;

	// Use this for initialization
	void Start () {
		Cam = GetComponent<Camera>();	
	}
	
	// Update is called once per frame
	void Update () {

		// "And" Operator
//		if (Input.GetKey("left shift")) {
//			if (Input.GetKey("t")) {
//				Debug.Log("Shift + T pressed");
//			}
//		}
		if (Input.GetKey("left shift") && Input.GetKey("t")) {
			Debug.Log("Shift + T pressed");
		}

		// "Or" Operator
		if (Input.GetKey("w") || Input.GetKey("up")) {
			Debug.Log("Move forward");
		}

		// "Not" operator
		if (!Input.GetKey("space")) {
			Debug.Log("Not space!");
		}

		// Combining
		int life = 10;
		if ((life > 0) && (Input.GetKey("space") || Input.GetKey("enter"))) {
			// Do something...
		}

	}
}
