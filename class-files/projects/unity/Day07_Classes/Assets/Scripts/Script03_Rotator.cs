using UnityEngine;
using System.Collections;

public class Script03_Rotator : MonoBehaviour {

	public float Speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Speed * Time.deltaTime, 0f, 0f);
	}

}
