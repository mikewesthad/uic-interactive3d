using UnityEngine;
using System.Collections;

public class FlashlightToggle : MonoBehaviour {

	private Light LightComponent;
	private AudioSource Audio;

	// Use this for initialization
	void Start () {
		LightComponent = GetComponent<Light>();
		Audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetMouseButtonDown(0)) {
//			if (LightComponent.enabled) {
//				LightComponent.enabled = false;
//			} else {
//				LightComponent.enabled = true;
//			}
//		}

		if (Input.GetMouseButtonDown(0)) {
			Audio.Play();
			Audio.pitch = Random.Range(0.9f, 1.1f);
			Invoke("ToggleLight", 0.1f);
		}
	}

	void ToggleLight() {
		LightComponent.enabled = !LightComponent.enabled;
	}
}
