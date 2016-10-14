using UnityEngine;
using System.Collections;

/*
	Exercise:
		- Get a single barking dog audio clip to play at random intervals from 
		  random positions around the player. Randomize the pitch every time the
		  sound is played.
		- Instead of using a single audio clip, use an array of clips 
		  (AudioClip[]). Pick a random clip to play every time a new bark needs
		  to happen.

	Code tips:
	AudioSource.pitch - allows you to get/set the pitch
	AudioSource.Play() - allows you to play an AudioSource
	AudioSource.clip - allows you to get/set the AudioClip on an AudioSource
*/

public class RandomBarking : MonoBehaviour {

	public AudioClip[] Clips;
	public Transform Player;
	private AudioSource Audio;

	// Use this for initialization
	void Start () {
		Audio = GetComponent<AudioSource>();

		// Schedule the first bark
		float delay = Random.Range(2f, 4f);
		Invoke("RandomBark", delay);
	}

	void RandomBark() {
		// Apply a random pitch shift
		Audio.pitch = Random.Range(0.8f, 1.2f);

		// Load a random audio clip
		int randomIndex = Random.Range(0, Clips.Length);
		Audio.clip = Clips[randomIndex];

		// Randomly teleport the AudioSource to somewhere random but nearby the
		// player
		transform.position = new Vector3(
			Player.position.x + Random.Range(-5f, 5f),
			Player.position.y,
			Player.position.z + Random.Range(-5f, 5f)
		);

		// Play the current clip
		Audio.Play();

		// Schedule a bark at a random time in the future
		float delay = Random.Range(2f, 4f);
		Invoke("RandomBark", delay);
	}
}
