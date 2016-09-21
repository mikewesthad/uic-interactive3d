using UnityEngine;
using System.Collections;

public class Script02_PoppingLights : MonoBehaviour {

	private Rigidbody RigidbodyComponent;
	private Material Mat;
	private float NextPopTime;
	private Light LightComponent;

	// Use this for initialization
	void Start () {
		RigidbodyComponent = GetComponent<Rigidbody>();
		Mat = GetComponent<MeshRenderer>().material;
		LightComponent = GetComponent<Light>();

		NextPopTime = Time.time + Random.Range(1f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= NextPopTime) {
			Pop();
			NextPopTime = Time.time + Random.Range(1f, 3f);
		}
	}

	void OnCollisionEnter() {
		Color randomColor = Random.ColorHSV(0f, 0.2f, 1f, 1f, 1f, 1f);
		LightComponent.color = randomColor;
		Mat.SetColor("_EmissionColor", randomColor);
	}

	void OnMouseDown() {
		Pop();
	}

	void Pop() {
		// Fire off in a random upward direction
		Vector3 force = new Vector3(
			Random.Range(-15f, 15f),
			Random.Range(15f, 30f),
			Random.Range(-15f, 15f)
		);
		RigidbodyComponent.AddForce(force, ForceMode.Impulse);
	}
}
