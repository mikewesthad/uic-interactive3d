using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	// Array 1: private HighScores that we fill with data in Start
	private int[] HighScores;

	// Array 2: public PlayerNames that we fill in using the inspector
	public string[] Items;

	// Array 3: array with initial data
	// Average hours of sunshine per month, data from: 
	// 	http://www.holiday-weather.com/chicago/averages/

	// Use this for initialization
	void Start () {

		// Array 1:
		// Initializing an array
		HighScores = new int[4];
		// Setting values in an array
		HighScores[0] = 10;
		HighScores[1] = 15;
		HighScores[2] = 12;
		HighScores[3] = 8;
		// Getting values from an array
		Debug.Log("The first high score is " + HighScores[0]);
		Debug.Log("The fourth high score is " + HighScores[3]);
		Debug.Log("There are " + HighScores.Length + " high scores saved.");

		// Array 2:
		// Looping through an array
		for (int i = 0; i < Items.Length; i += 1) {
			Debug.Log("Item " + (i + 1) + "'s name: " + Items[i]);
		}
		// An alternate loop structure: foreach
		// Useful for looping through when you just need to read/manipulate 
		// elements in an array
		foreach (string item in Items) {
			Debug.Log("You have: " + item + ".");
		}

		// Array 3:
		// Loop through the array and create an instance of the SimpleCube model
		// for each month. Manipulate each cube so that:
		//  - Its height (e.g. y-scale) reflects the hours of sunshine in that 
		//    month
		//  - Its color reflects the hours of sunshine in that month (e.g. from
		//    black to yellow)

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
