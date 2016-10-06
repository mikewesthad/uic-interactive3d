using UnityEngine;
using System.Collections;

public class DestroyPathBonus : MonoBehaviour {

	private Camera Cam;
	public float DigDistance = 8f;
	public float TorchDistance = 2f;
	public float SphereRadius = 0.5f;
	public GameObject Torch;

	// Use this for initialization
	void Start () {
		Cam = GetComponent<Camera>();
	}

	// Update is called once per frame
	void Update () {

		// Left click dig
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay(ray.origin, ray.direction * DigDistance, Color.red, 1f);

			// Bonus: sphere casting
			RaycastHit[] hits = Physics.SphereCastAll(ray, SphereRadius, DigDistance);
			foreach (RaycastHit hit in hits) {
				if (hit.transform.tag != "Player") {
					Destroy(hit.transform.gameObject);
				}
			}
		} 

		// Right click to place torch
		if (Input.GetMouseButtonDown(1)) {
			Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay(ray.origin, ray.direction * TorchDistance, Color.red, 1f);
			if (!Physics.Raycast(ray, TorchDistance)) {
				Instantiate(Torch, ray.GetPoint(TorchDistance), Quaternion.identity);
			}
		} 
	}

	// Debugging with Gizmos!
	void OnDrawGizmos() {
		if (Cam == null) {
			// This runs even when we aren't in play mode, so to prevent errors,
			// check to make sure we have a Camera reference.
			return;  
		}
		// Draw a series of spheres along the SphereCastAll's path
		Gizmos.color = new Color(1, 0, 0, 0.5f);
		Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
		for (float i = 0; i < DigDistance; i += SphereRadius) {
			Vector3 point = ray.GetPoint(i);
			Gizmos.DrawSphere(point, SphereRadius);
		}
	}
}
