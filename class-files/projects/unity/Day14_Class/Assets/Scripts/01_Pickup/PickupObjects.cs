using UnityEngine;
using System.Collections;

public class PickupObjects : MonoBehaviour {

	public float PickupDistance = 3f;
	private Camera Cam;
	private Transform ObjectBeingHeld = null;

	// Use this for initialization
	void Start () {
		Cam = Camera.main;
		// Or:
		// Cam = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

		// Left mouse down
		if (Input.GetMouseButtonDown(0) && (ObjectBeingHeld == null)) {

			// Get the ray
			Ray ray = Cam.ScreenPointToRay(Input.mousePosition);

			// Raycast
			RaycastHit hit;
			bool isHit = Physics.Raycast(ray, out hit, PickupDistance);

			// Pickup
			if (isHit && (hit.transform.tag == "Pickupable")) {
				Debug.Log(hit.transform.name + " : " + hit.transform.tag);
				hit.rigidbody.isKinematic = true;
				hit.transform.parent = transform;
				ObjectBeingHeld = hit.transform;
			}

		}

		// Left mouse up and we have an object to drop
		if (Input.GetMouseButtonUp(0) && (ObjectBeingHeld != null)) {
			ObjectBeingHeld.GetComponent<Rigidbody>().isKinematic = false;
			ObjectBeingHeld.parent = null;
			ObjectBeingHeld = null;
		}
		
	}
}
