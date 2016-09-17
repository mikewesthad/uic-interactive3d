using UnityEngine;
using System.Collections;

public class Staring : MonoBehaviour {

	private Transform PlayerTransform;

	// Use this for initialization
	void Start () {
		// This is a little more "fragile" of a way to find an object. If you
		// rename your player at some point, this script will break. If you use
		// the inspector method of getting other game components, renaming won't
		// break things.
		GameObject player = GameObject.Find("RigidBodyFPSController");
		PlayerTransform = player.transform;

		RandomizeTransform();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(PlayerTransform);

		// Advanced: remove any rotation around the X/Y axes
		// You can't use eulerAngles if you are trying to increment an angle. 
		// (That's why we didn't use it for the fly controller.
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
	}

	// Note: not part of the homework - just for fun
	void RandomizeTransform() {
		// Modify the X/Z position, but leave Y along so that the Pokemon
		// stays on the plane
		Vector3 position = transform.position;
		position.x = Random.Range(-10f, 10f);
		position.z = Random.Range(-10f, 10f);
		transform.position = position; // Leave this off for funky effects

		// Random scale
		float randomScale = Random.Range(0.5f, 1.5f);
		transform.localScale = Vector3.one * randomScale;
	}
}
