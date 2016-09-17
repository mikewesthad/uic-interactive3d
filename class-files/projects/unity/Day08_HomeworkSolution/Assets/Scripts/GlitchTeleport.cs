using UnityEngine;
using System.Collections;

public class GlitchTeleport : MonoBehaviour {

	public Transform PlayerTransform;
	public float TriggerDistance = 5f;

	private Material Mat;

	// Use this for initialization
	void Start () {
		Mat = GetComponent<MeshRenderer>().material;	
	}
	
	// Update is called once per frame
	void Update () {

		float distance = Vector3.Distance(transform.position, PlayerTransform.position);
		if (distance <= TriggerDistance) {

			// Modify the X/Z position, but leave Y along so that the Pokemon
			// stays on the plane
			Vector3 position = transform.position;
			position.x = Random.Range(-10f, 10f);
			position.z = Random.Range(-10f, 10f);
			transform.position = position; // Leave this off for funky effects

			// Random color
			Mat.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f);

			// Random scale
			transform.localScale = new Vector3(
				Random.Range(0.25f, 5f),
				Random.Range(0.25f, 5f),
				Random.Range(0.25f, 5f)
			);
				
			// "Look" in a random direction
			transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
		}
	
	}
}
