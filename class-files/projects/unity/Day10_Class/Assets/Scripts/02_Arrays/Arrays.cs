using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	// Array 1: private HighScores that we fill with data in Start
	private int[] HighScores;

	// Array 2: public PlayerNames that we fill in using the inspector
	public string[] PlayerNames;

	// Array 3: array with initial data
	// Average hours of sunshine per month, data from: 
	// 	http://www.holiday-weather.com/chicago/averages/

	// Use this for initialization
	void Start () {

		// Array 1:
		// Initializing an array
		HighScores = new int[4];
		HighScores[0] = 10; 
		HighScores[1] = 12;
		HighScores[2] = 15;
		HighScores[3] = 13;
		Debug.Log("The first high score is: " + HighScores[0]);
		Debug.Log("The last high score is: " + HighScores[3]);
		Debug.Log("The number of high scores is: " + HighScores.Length);

		// Array 2:
		// Looping through an array
		for (int i = 0; i < PlayerNames.Length; i += 1) {
			Debug.Log("Player's name " + PlayerNames[i]);
		}
		foreach (string name in PlayerNames) {
			Debug.Log(name);
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
