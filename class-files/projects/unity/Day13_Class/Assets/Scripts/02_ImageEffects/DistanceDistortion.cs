using UnityEngine;
using System.Collections;

// Gives us access to script classes in Image Effects
using UnityStandardAssets.ImageEffects;

public class DistanceDistortion : MonoBehaviour {

	public Transform PlayerTransform;
	public float TriggerDistance = 8f;

	// EdgeDetection is the class for the "Edge Detection" script - there is an
	// instance of that class attached to the camera
	public EdgeDetection EdgeFilter;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float distance = Vector3.Distance(transform.position, PlayerTransform.position);
		if (distance <= TriggerDistance) {

			// How do you get a number between 0 and 1 from distance?
			float fractionDistance = distance / TriggerDistance;

			// When manipulating an image effect, you need to look up the public
			// variable names in the image effect's script
			EdgeFilter.edgeExp = Mathf.Lerp(10f, 1f, fractionDistance);
			EdgeFilter.sampleDist = Mathf.Lerp(4f, 0f, fractionDistance);
			EdgeFilter.edgesOnly = Mathf.Lerp(0.5f, 0f, fractionDistance);

		} else {
			EdgeFilter.edgeExp = 1f;
			EdgeFilter.sampleDist = 0f;
			EdgeFilter.edgesOnly = 0f;
		}
		
	}
}
