using UnityEngine;
using System.Collections;

public class Script04_Distance : MonoBehaviour {

	public Transform PlayerTransform;
	public float DistanceThreshold = 5f;

	private MeshRenderer RendererComponent;
	private Material Mat;

	// Use this for initialization
	void Start () {
		RendererComponent = GetComponent<MeshRenderer>();
		Mat = RendererComponent.material;
		
	}

	// Update is called once per frame
	void Update () {

		float distance = Vector3.Distance(transform.position, PlayerTransform.position);

		if (distance <= DistanceThreshold) {
			Mat.color = new Color(1f, 0f, 0f);
		} else {
			Mat.color = new Color(0f, 0f, 0f);
		}
	}
}
