using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {

	void Start () {
		Debug.Log("Circumference for 10 radius: " + CircleCircumference(10));
		Debug.Log("Circumference for 20 radius: " + CircleCircumference(20));

		Debug.Log("32 F to C: " + ConvertFahrenheitToCelsius(32));
		Debug.Log("100 F to C: " + ConvertFahrenheitToCelsius(100));

		SingBirthdaySong("Obama");
		SingBirthdaySong("Duchamp");

		PrintMagentaMessage("I am so magenta");

		PrintColorfulMessage("I am so orange", "orange");

		SingColorfulBirthdaySong("Ada Lovelace");
	}

	float CircleCircumference(float radius) {
		float circumference = 2 * radius * 3.14f;
		// Or:
		// float circumference = 2 * radius * Mathf.PI;
		return circumference;
	}

	float ConvertFahrenheitToCelsius(float fahrenheit) {
		float celsius = (fahrenheit - 32f) * 5f / 9f;
		return celsius;
	}

	void SingBirthdaySong(string name) {
		Debug.Log("Happy birthday to you");
		Debug.Log("Happy birthday to you");
		Debug.Log("Happy birthday dear " + name);
		Debug.Log("Happy birthday to you.");
	}

	void PrintMagentaMessage(string message) {
		string magentaMessage = "<color=magenta>" + message + "</color>";
		Debug.Log(magentaMessage);
	}

	void PrintColorfulMessage(string message, string color) {
		string colorMessage = "<color=" + color + ">" + message + "</color>";
		Debug.Log(colorMessage);
	}

	void SingColorfulBirthdaySong(string name) {
		PrintColorfulMessage("Happy birthday to you", "cyan");
		PrintColorfulMessage("Happy birthday to you", "orange");
		PrintColorfulMessage("Happy birthday dear " + name, "red");
		PrintColorfulMessage("Happy birthday to you", "green");
	}

}
