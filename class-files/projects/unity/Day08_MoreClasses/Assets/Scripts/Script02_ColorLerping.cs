using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Light))]
public class Script02_ColorLerping : MonoBehaviour {

	public Color StartColor = new Color(1f, 0f, 0f);
	public Color EndColor = new Color(1f, 0f, 1f);
	public float LerpAmount = 0f;

	private Light LightComponent;

	// Use this for initialization
	void Start () {
		LightComponent = GetComponent<Light>();

		LightComponent.color = Color.Lerp(StartColor, EndColor, 0f);
	}

	// Update is called once per frame
	void Update () {
		// Manual increment to change the interpolation
//		LerpAmount += 0.25f * Time.deltaTime;
//		LightComponent.color = Color.Lerp(StartColor, EndColor, LerpAmount);

		// Using Mathf.PingPong to get lerped colors
//		float duration = 0.5f; // Seconds
//		float pongedTime = Mathf.PingPong(Time.time, duration); // 0 to 2
//		float lerpAmount = pongedTime / duration; // 0 to 1
//		Color color = Color.Lerp(StartColor, EndColor, lerpAmount);
//		LightComponent.color = color;

		// Use our utility to animate multiple properties
		LightComponent.color = AnimationUtilities.MappedPingPong(2f, StartColor, EndColor);
		LightComponent.spotAngle = AnimationUtilities.MappedPingPong(0.5f, 0f, 100f);


	}
}
