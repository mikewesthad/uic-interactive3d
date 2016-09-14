using UnityEngine;
using System.Collections;

public class Script05_ColorLerping : MonoBehaviour {

	private Light LightComponent;

	public Color StartColor;
	public Color EndColor;
	public float LerpAmount = 0f;

	// Use this for initialization
	void Start () {
		LightComponent = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		LerpAmount += .25f * Time.deltaTime;
		LightComponent.color = Color.Lerp(StartColor, EndColor, LerpAmount);

		// Using Time and PingPong to creating a repeating pulse
		LerpAmount = Mathf.PingPong(Time.time, 4f) / 4f;
		LightComponent.color = Color.Lerp(StartColor, EndColor, LerpAmount);
	}
}
