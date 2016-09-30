using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	public float ExplosionRange = 10f;

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag != "Player") {
			ExplodeSphere();
			Destroy(gameObject); // Destroy AFTER exploding
		}
	}

	private void ExplodeSphere() {
		// Get all colliders within range of the poke ball's transform
		Collider[] colliderArray = Physics.OverlapSphere(transform.position, ExplosionRange);

		// For each collider in range, apply an explosive force if it has a
		// rigidbody
		foreach (Collider colliderElement in colliderArray) {
			Rigidbody rb = colliderElement.attachedRigidbody;
			// Some things may not have a rigidbody (e.g. the ground)
			if (rb != null) {
				rb.AddExplosionForce(5000f, transform.position, ExplosionRange, 0.25f);
			}
		}

		// The foreach loop is equivalent to the following for loop:
//		for (int i = 0; i < colliderArray.Length; i += 1) {
//			Collider colliderElement = colliderArray[i];
//		}
	}

	// Special Unity method for drawing debug information with Gizmos
	void OnDrawGizmos() {
		Gizmos.color = new Color(0.4f, 0f, 1f, 0.5f);
		Gizmos.DrawSphere(transform.position, ExplosionRange);
		Gizmos.color = Color.black;
		Gizmos.DrawWireSphere(transform.position, ExplosionRange);
	}
}
