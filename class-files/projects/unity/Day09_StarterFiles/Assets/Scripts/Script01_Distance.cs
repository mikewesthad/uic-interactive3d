using UnityEngine;
using System.Collections;

public class Script01_Distance : MonoBehaviour {

	public Transform PlayerTransform;
	public float DistanceTrigger = 10f;
	public Color NearColor;
	public Color FarColor;

	private MeshRenderer RendererComponent;
	private Material Mat;

	// Use this for initialization
	void Start () {
		RendererComponent = GetComponent<MeshRenderer>();
		Mat = RendererComponent.material;
	}

	// Update is called once per frame
	void Update () {
		// Code from the end of last class:
		float distance = Vector3.Distance(PlayerTransform.position, transform.position);
		Debug.Log(distance);
		if (distance <= DistanceTrigger) {
			Mat.color = NearColor;
		} else {
			Mat.color = FarColor;
		}
	}
}
