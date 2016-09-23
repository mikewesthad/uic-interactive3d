using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

	// Use this for initialization
	void Start () {

//		for (int i = 1; i <= 50; i += 10) {
//			Debug.Log("The current count is: " + i);
//		}

		// DANGER ZONE
//		for (int i = 10; i >= 10; i += 1) {
//			Debug.Log("The current count is: " + i);
//		}

		// Summing all the numbers from 1 to 10 together
//		int sum = 0;
//		for (int i = 1; i <= 10; i += 1) {
//			sum += i;
//		}
//		Debug.Log("The sum is: " + sum);

		// Write a loop that prints the numbers 5 through 15
//		for (int i = 5; i <= 15; i += 1) {
//			Debug.Log("The count is: " + i);
//		}

		// Write a loop that counts from 0 through 100, in increments of 10
//		for (int i = 0; i <= 100; i += 10) {
//			Debug.Log("The count is: " + i);
//		}

		// Write a loop that counts down from 10 to 0
		for (int i = 10; i >= 0; i -= 1) {
			Debug.Log("The count is: " + i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
