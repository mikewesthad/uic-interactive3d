using UnityEngine;
using System.Collections;

// Exercise:
// 	- Instantiate a flower at the hit point (just pick your favorite of the 
// 	  models)
//  	- Look at the RaycastHit documentation to figure out how to do that
// 		- Give the flower a random (uniform) scale in order to add some variety
//  - Extension: instead of just using your favorite flower model, modify your 
//    code so that a random flower is planted
// 		- Remember how we spawned random Pokemon in the last scene?
//  - Extra bonus: what about animating the flowers so that they scale in from
//    0 when they are planted?
// 		- Hint: you can create flower prefabs that have a Grow.cs script 
// 		  attached. That script can then handle the animation.


public class SpawnRaycast : MonoBehaviour {

	public GameObject[] Flowers;
	public float RayDistance = 5f;

	private Camera Cam;

	// Use this for initialization
	void Start () {
		Cam = GetComponent<Camera>();
	}

	// Update is called once per frame
	void Update () {

		// Get a ray that points from the mouse position through the camera and
		// out into the 3D world
//		Debug.Log(Input.mousePosition);
		Ray ray = Cam.ScreenPointToRay(Input.mousePosition);

		// Draw the ray so that we can see where it points
		// We can do math on vectors:
		// (0, 0, 1) * 10 = (0, 0, 10)
		// (2, 0, 10) / 2 = (1, 0, 5)
		// ray.direction is normalized, so we can scale it to the distance we
		// want
		Debug.DrawRay(ray.origin, ray.direction * RayDistance, Color.red, 1f);

		if (Input.GetMouseButtonDown(0)) {

			// Raycast using the camera ray
			RaycastHit hit;
			bool isHit = Physics.Raycast(ray, out hit, RayDistance);
			if (isHit) {
				// If we hit something, plant a random flower
				int index = Random.Range(0, Flowers.Length);
				GameObject flowerPrefab = Flowers[index];
				GameObject flower = (GameObject) Instantiate(flowerPrefab, hit.point, Quaternion.identity);
				flower.transform.localScale = Vector3.one * Random.Range(10f, 15f);
			}

		} 
	}

}