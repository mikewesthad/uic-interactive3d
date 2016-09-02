using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

	// Use this for initialization
	void Start() {

		// -- BASIC VARIABLES --------------------------------------------------

		// Integers (whole numbers)
		int numJupiterMoons = 67;
		// Debug.Log(numJupiterMoons);
		// Errors:
		// int temperature = 99.5;
		// int bigNumber = 1000000000000;
		
		// Floats (floating decimal points)
		float taxAmount = 0.07f;
		// Debug.Log(taxAmount);
		// Errors:
		// float testScore = 92.5;

		// Strings (collections of characters)
		string welcomeMessage = "Perfect is the enemy of good.";
		// Debug.Log(welcomeMessage);

		// -- CONCATENATION ----------------------------------------------------
		
		Debug.Log("Jupiter has " + numJupiterMoons + " moons.");

		// Be careful of order of operations!
		Debug.Log("Jupiter now has " + numJupiterMoons + 1 + " moons.");
		// This would print: "Jupiter now has 671 moons."

		// -- MATH OPERATORS ---------------------------------------------------

		int total = 23 + 17 + 20;
		Debug.Log("The total is " + total);

		int numPlanets = 9;
		numPlanets = numPlanets - 1; // Bye bye Pluto :(
		Debug.Log("Number of planets: " + numPlanets);
		numPlanets = numPlanets * 2; // All planets undergo mitosis 
		Debug.Log("Number of planets: " + numPlanets);

		// Math works as expected... depending on the data type
		Debug.Log(6 / 3); // -> 2
		// Debug.Log(6 / "3"); // -> Error! Can't divide int by string
		Debug.Log(7 / 3); // -> 2, wtf? Integer math.
		Debug.Log(7 / 3f); // -> 2.3333, that's better.

		// -- EXERCISES --------------------------------------------------------

		// Create a variable that holds the total cost of three items:
		//  - magnets, $25.75
		//  - LEDs, $15.10
		//  - tape, $3.10
		float magnetPrice = 25.75f;
		float ledPrice = 15.10f;
		float tapePrice = 3.10f;
		float totalCost = magnetPrice + ledPrice + tapePrice;

		// Print the value of your total cost variable:
		Debug.Log("The total price is: $" + totalCost);

		// Now factor in a discount of 25% off and print out the new total:
		float discountTotal = totalCost * 0.75f;
		Debug.Log("The discounted price is: $" + discountTotal);

		// Find the average of the following test scores: 100, 90, 85, 74, 82
		float averageScore = (100 + 90 + 85 + 74 + 82) / 5f;
		Debug.Log("The average score is: " + averageScore);        
	}
	
}
