using UnityEngine;
using System.Collections;

public class CreateGrid : MonoBehaviour {

	public GameObject PrefabCube;
	public int width = 12;
	public int height = 12;
	public int depth = 12;


	// Use this for initialization
	void Start () {
		for (int x = 0; x < width; x += 1) {
			for (int y = 0; y < height; y += 1) {
				for (int z = 0; z < depth; z += 1) {
					GameObject clone = (GameObject) Instantiate(PrefabCube, transform);
					// Place object at a local position rather than a global one
					clone.transform.localPosition = new Vector3(x, y, z);
					// Random:
//					clone.GetComponent<MeshRenderer>().material.color = Random.ColorHSV(0f, 0.2f, 0.8f, 1f, 0.8f, 1f);
					// Or mapping:
					Color c = Color.HSVToRGB(x / (width - 1f), y / (height - 1f), z / (depth - 1f));
					clone.GetComponent<MeshRenderer>().material.color = c;
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
