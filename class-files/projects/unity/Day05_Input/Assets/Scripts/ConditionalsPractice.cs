using UnityEngine;
using System.Collections;

public class ConditionalsPractice : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// First part of demo from class:
		float score = 40f;

		// Order of conditions matters!
		if (score >= 95f) {
			Debug.Log("Good job, you get a sticker.");
		} else if (score >= 50f) {
			Debug.Log("You passed :)");
		} else {
			Debug.Log("You failed :(");
		}
			

		// Second part of demo from class: 
		Debug.Log("The grade is: " + GradeExam(100f));
		Debug.Log("The grade is: " + GradeExam(89f));
		Debug.Log("The grade is: " + GradeExam(74f));
		Debug.Log("The grade is: " + GradeExam(63f));
		Debug.Log("The grade is: " + GradeExam(42f));
			
	}

	string GradeExam(float score) {
		if (score >= 90) {
			return "A";
		} else if (score >= 80) {
			return "B";
		} else if (score >= 70) {
			return "C";
		} else if (score >= 60) {
			return "D";
		} else {
			return "F";
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
