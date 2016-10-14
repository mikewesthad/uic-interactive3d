using UnityEngine;
using System.Collections;

public class TriggerDome : MonoBehaviour {

	public Light DiscoLight;
	private AudioSource Audio;
	private bool IsInRoom = false;

	// Use this for initialization
	void Start () {
		Audio = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		if (IsInRoom) {
			DiscoLight.transform.Rotate(0f, 0f, 45f * Time.deltaTime);
		}

		// Alternative:
//		if (Audio.isPlaying) {
//			DiscoLight.transform.Rotate(45f * Time.deltaTime, 0f, 0f);
//		}
	}

	void OnTriggerEnter() {
		Audio.Play();
		IsInRoom = true;
	}

	void OnTriggerExit() {
		Audio.Pause();
		IsInRoom = false;
	}
}