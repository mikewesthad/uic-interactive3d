using UnityEngine;
using System.Collections;

public class Script04_LightFade : MonoBehaviour {

	private Light LightComponent;

	// Use this for initialization
	void Start () {
		LightComponent = GetComponent<Light>();
		LightComponent.intensity = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		// Original fade in code
//		if (LightComponent.intensity < 4f) {
//			LightComponent.intensity += 1f * Time.deltaTime;
//		}

		// Code for making the fade repeat or ping pong
//		LightComponent.intensity = Mathf.Repeat(Time.time, 4f);
		LightComponent.intensity = Mathf.PingPong(Time.time, 4f);


	}
}
