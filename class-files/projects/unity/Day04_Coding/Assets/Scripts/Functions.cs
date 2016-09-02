using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {

	// Use this for initialization
	void Start() {
		PrintWelcomeMessage();

		WelcomePlayer("Mike");
		WelcomePlayer("Tongxin");
		WelcomePlayer("Caleb");

		int perimeter1 = CalculateRectanglePerimeter(10, 20);
		Debug.Log(perimeter1);
		float perimeter2 = CalculateRectanglePerimeter(40.5f, 10f);
		Debug.Log(perimeter2);

		// Calling functions from class exercise
		// 1)
		ComplimentPlayer("Bob");
		// 2)
		float area1 = CalculateRectangleArea(10.25f, 19.5f);
		// 3)
		float numAverage = CalculateAverage(10.5f, 7.75f, 6f);
		Debug.Log("The average is " + numAverage);
		// 4)
		float discountedCost = ApplyDiscount(19.99f, 0.3f);
		Debug.Log("The discounted cost is: " + discountedCost);
	}

	void PrintWelcomeMessage() {
		Debug.Log("Hello there. The console welcomes you.");
	}

	void WelcomePlayer(string playerName) {
		// playerName is local! You cannot access it from outside of this scope.
		Debug.Log("Hello there, " + playerName + ". Welcome!");
	}

	int CalculateRectanglePerimeter(int width, int height) {
		// Debug.Log("Integer Perimeter");
		int perimeter = (2 * width) + (2 * height);
		return perimeter;
	}

	float CalculateRectanglePerimeter(float width, float height) {
		// Debug.Log("Float Perimeter");
		// width, height and perimeter are local
		float perimeter = (2f * width) + (2f * height);
		return perimeter;
	}

	// - EXERCISES -------------------------------------------------------------

	// Create a ComplimentPlayer function that takes one string parameter 
	// (playerName) and prints something nice about the player (e.g. 
	// "[Player name], you look nice today.")
	// Test it by invoking the function with your name.
	void ComplimentPlayer(string playerName) {
		Debug.Log(playerName + ", you look nice today");
	}

	// Create a CalculateRectangleArea function that takes two float parameters
	// (one for width and one for height) and returns the area of the rectangle.
	// Test it by calculating the area of a 10.25 x 19.5 rectangle.
	float CalculateRectangleArea(float width, float height) {
		float area = width * height;
		return area;
	}

	// Create a CalculateAverage function that takes three float parameters, 
	// averages them and returns the result.
	// Test it by calculating the average of 10.5, 7.75 and 6.
	float CalculateAverage(float num1, float num2, float num3) {
		float average = (num1 + num2 + num3) / 3;
		return average;
	}

	// Create an ApplyDiscount function that takes two floats - a total cost
	// and a discount fraction (e.g. .25) - and returns the final discounted 
	// price.
	// Test it by calculating the discounted price of an item that is 19.99 and 
	// on sale for 30% off.
	float ApplyDiscount(float itemCost, float discountDecimal) {
		float discount = itemCost * discountDecimal;
		float newCost = itemCost - discount;
		return newCost;
	}
}
