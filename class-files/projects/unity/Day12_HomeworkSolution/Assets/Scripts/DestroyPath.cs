using UnityEngine;
using System.Collections;

public class DestroyPath : MonoBehaviour {
	
	private Camera Cam;
	public float RayDistance = 3f;

	// Use this for initialization
	void Start () {
		Cam = GetComponent<Camera>();	
	}
	
	// Update is called once per frame
	void Update () {

		// Left click dig
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay(ray.origin, ray.direction * RayDistance, Color.red, 1f);

			// Get ALL hits within a specified distance
			RaycastHit[] hits = Physics.RaycastAll(ray, RayDistance);
			foreach(RaycastHit hit in hits) {
				// Lookup the GameObject instance that we hit using "hit"
				Destroy(hit.transform.gameObject);
			}
		} 
	}
}
