using UnityEngine;
using System.Collections;

public class TriggerMusicCube : MonoBehaviour {

	public Color InactiveColor;
	public Color ActiveColor;

	private AudioSource Audio;
	private Material Mat;

	// Use this for initialization
	void Start () {
		Mat = GetComponent<MeshRenderer>().material;
		Audio = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		if (Audio.isPlaying) {
			Mat.color = ActiveColor;
		} else {
			Mat.color = InactiveColor;
		}
	}

	void OnTriggerEnter() {
		Audio.Play();
	}
}