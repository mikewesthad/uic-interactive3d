using UnityEngine;
using System.Collections;

public class SpawnMusicalCubes : MonoBehaviour {

	public GameObject CubePrefab;
	public AudioClip[] Clips;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < Clips.Length; i += 1) {
			GameObject clone = (GameObject) Instantiate(CubePrefab, transform);
			clone.GetComponent<AudioSource>().clip = Clips[i];
			clone.transform.localPosition = new Vector3(i * 2f, 0.5f, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
