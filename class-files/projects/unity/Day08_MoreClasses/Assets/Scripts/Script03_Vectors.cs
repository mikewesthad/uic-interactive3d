using UnityEngine;
using System.Collections;

public class Script03_Vectors : MonoBehaviour {

	private MeshRenderer RendererComponent;
	private Material Mat;

	// Use this for initialization
	void Start () {

		// Do not do this!
//		transform.position.x = 10f;

		// Replacement method 
//		transform.position = new Vector3(0f, 10f, 0f);

		// Modify method
//		Vector3 position = transform.position;
//		position.z += 6f;
//		transform.position = position;

		// Modify scale to be 5 in the x direction
//		Vector3 scale = transform.localScale;
//		scale.x = 5f;
//		transform.localScale = scale;

		RendererComponent = GetComponent<MeshRenderer>();
		Mat = RendererComponent.material;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver() {
		float x = Random.Range(-3f, 3f);
		float y = Random.Range(2f, 4f);
		float z = Random.Range(-3f, 3f);
		transform.position = new Vector3(x, y, z);

		transform.localScale = new Vector3(
			Random.Range(0.25f, 5f),
			Random.Range(0.25f, 5f),
			Random.Range(0.25f, 5f)
		);

		// RGB Approach
//		Mat.color = new Color(
//			Random.Range(0f, 1f), 
//			Random.Range(0f, 1f),
//			Random.Range(0f, 1f)
//		);

		// HSV Approach
		Mat.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);

		// Random Quaternion
		transform.rotation = Random.rotationUniform;
	}
}
