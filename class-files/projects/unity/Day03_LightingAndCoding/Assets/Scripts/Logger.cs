using UnityEngine;
using System.Collections;

public class Logger : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// This is a single line comment

		// Setup Notes: 
		// - Make sure this file is attached to a game object in the scene!
		// - Open up the console window.

		// Printing to the console
		Debug.Log("I'm running!");
		Debug.Log("ヽ(´▽`)/"); // https://github.com/dysfunc/ascii-emoji
		Debug.Log(42);

		/* Delimited comments look like this. */

		/*
		 * They can be used to create comments that span multiple lines.
		 * @('_')@
		*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
