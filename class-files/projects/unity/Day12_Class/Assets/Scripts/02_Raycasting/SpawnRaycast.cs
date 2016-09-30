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

	private Camera MainCamera;

	public float Range = 2f;
	public GameObject[] FlowerPrefabs;

	// Use this for initialization
	void Start () {
		MainCamera = GetComponent<Camera>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {

			// Use the camera to find a ray that from the screen into the world
			Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay(ray.origin, ray.direction * Range, Color.red, 2f);

			// Check if the ray collides with anything in the world
			RaycastHit hit;
			bool isHit = Physics.Raycast(ray, out hit, Range);

			if (isHit) {

				// Pick a random index from our array of prefabs
				int randomIndex = Random.Range(0, FlowerPrefabs.Length);
				// Use the random index to look up a prefab
				GameObject randomFlower = FlowerPrefabs[randomIndex];

				// Using a random prefab, instantiate a flower at the ray's 
				// hit point
				GameObject flowerClone = (GameObject) Instantiate(randomFlower, hit.point, Quaternion.identity);
				flowerClone.transform.localScale = Vector3.one * Random.Range(10f, 15f);

				Debug.Log("We just hit: " + hit.point);
				Debug.Log("It was " + hit.distance + " away.");
			} else {
				Debug.Log("Didn't hit something!");
			}
		}
	}

}