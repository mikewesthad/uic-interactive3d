using UnityEngine;
using System.Collections;

public class FireExplosive : MonoBehaviour {

	public GameObject ExplosivePrefab;
	public float ExplosiveForce = 15f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {
			// Spawn the pokeball at the transform's position AND rotation
			GameObject clone = (GameObject) Instantiate(ExplosivePrefab, 
				transform.position, transform.rotation);

			Rigidbody rb = clone.GetComponent<Rigidbody>();

			// GLOBAL - not what we want
//			rb.AddForce(new Vector3(0f, 0f, 10f), ForceMode.Impulse);

			rb.AddRelativeForce(new Vector3(0f, 5f, ExplosiveForce), ForceMode.Impulse);

			rb.AddRelativeTorque(new Vector3(400f, 200f, 0f));

//			Debug.Break();
		}

	}
}
