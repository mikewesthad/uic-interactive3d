using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Light))]
public class Script01_LightFade : MonoBehaviour {

	public float FadeSpeed = 0.5f; // Intensity units per second

	private Light LightComponent;
	private bool FadingIn = true;

	// Use this for initialization
	void Start () {
		LightComponent = GetComponent<Light>();

		// Now we can access the fields and methods of the Light instance
		LightComponent.intensity = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {

		// Updating the intensity to create a fade in
//		if (LightComponent.intensity < 5f) {
//			LightComponent.intensity += FadeSpeed * Time.deltaTime;
//		}

		// Creating our own ping pong fading effect
//		if (FadingIn) {
//			LightComponent.intensity += FadeSpeed * Time.deltaTime;
//			if (LightComponent.intensity >= 5f) {
//				FadingIn = false;
//			}
//		}
//		else {
//			LightComponent.intensity -= FadeSpeed * Time.deltaTime;
//			if (LightComponent.intensity <= 1f) {
//				FadingIn = true;
//			}
//		}

		// Using Mathf.PingPong to get intensities between 1 and 5
//		float duration = 2f; // Seconds
//		float pongedTime = Mathf.PingPong(Time.time, duration); // 0 to 2
//		float lerpAmount = pongedTime / duration; // 0 to 1
//		float intensity = Mathf.Lerp(1, 5, lerpAmount); // 1 to 5
//		LightComponent.intensity = intensity;

		// Use our utility to animate multiple properties
		LightComponent.intensity = AnimationUtilities.MappedPingPong(0.5f, 1f, 5f);
		LightComponent.spotAngle = AnimationUtilities.MappedPingPong(2f, 0f, 120f);

	}
}
