using UnityEngine;
using System.Collections;

public class Instantiating : MonoBehaviour {

	public GameObject Prefab;

	// Use this for initialization
	void Start () {

		// Creating a copy of an object
//		Vector3 spawnPoint = new Vector3(0f, 2f, 0f);
//		Quaternion rotation = Quaternion.identity;
//		Instantiate(Prefab, spawnPoint, rotation);

		// Spawning and casting
//		GameObject clone = (GameObject) Instantiate(Prefab, new Vector3(1f, 0f, 0f), 
//			rotation);
//		clone.transform.localScale = new Vector3(1f, 3f, 1f);
//		Material mat = clone.GetComponent<MeshRenderer>().material;
//		mat.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);

		// Looping and spawning a row
//		for (int i = 0; i < 10; i += 1) {
//			GameObject cube = (GameObject) Instantiate(Prefab, 
//				new Vector3(i * 2f, 0f, 0f), Quaternion.identity);
//			cube.name = "Cube: " + i;
//			Material cloneMaterial = cube.GetComponent<MeshRenderer>().material;
//			cloneMaterial.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);
//		}

		// Mapping 
		// Challenge: create a row that forms a rainbow of colors
//		for (int i = 0; i < 10; i += 1) {
//			GameObject cube = (GameObject) Instantiate(Prefab, 
//				new Vector3(i * 2f, 0f, 0f), Quaternion.identity);
//			cube.name = "Cube: " + i;
//			Material cloneMaterial = cube.GetComponent<MeshRenderer>().material;
//			cloneMaterial.color = Color.HSVToRGB(i / 9f, 1f, 1f);			
//		}


		// Grid - 2D loop
//		for (int x = 0; x < 10; x += 1) {
//			for (int y = 0; y < 10; y += 1) {
//				Vector3 point = new Vector3(x * 1.5f, y * 1.5f, 0f);
//				Instantiate(Prefab, point, Quaternion.identity);
//			}
//		}

		// Challenge: create a grid where hue changes along the x-axis and value
		// changes along the y-axis
		for (int x = 0; x < 10; x += 1) {
			for (int y = 0; y < 10; y += 1) {
				Vector3 point = new Vector3(x * 1.5f, y * 1.5f, 0f);
				Quaternion rotation = Quaternion.Euler(x * 10, y * 10, 0);
				GameObject clone = (GameObject) Instantiate(Prefab, point, rotation);
				Material cloneMaterial = clone.GetComponent<MeshRenderer>().material;
				cloneMaterial.color = Color.HSVToRGB(x / 9f, 1f, y / 9f);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
