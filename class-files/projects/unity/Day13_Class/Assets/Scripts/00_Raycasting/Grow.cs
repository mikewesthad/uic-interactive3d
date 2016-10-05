using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour {

	public float StartScale = 0f;
	public float EndScale = 20f;
	public float ScaleSpeed = 1f; // Scale units per second

	private float CurrentScale = 0f;

	// Use this for initialization
	void Start () {
		CurrentScale = StartScale;
		transform.localScale = Vector3.one * CurrentScale;
	}
	
	// Update is called once per frame
	void Update () {
		CurrentScale += ScaleSpeed * Time.deltaTime;
		if (CurrentScale <= EndScale) {
			transform.localScale = Vector3.one * CurrentScale;	
		} else {
			transform.localScale = Vector3.one * EndScale;
			enabled = false; // Turns the script off
		}
	
	}
}
