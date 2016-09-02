using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

	// Use this for initialization
	void Start() {

		// -- BASIC VARIABLES --------------------------------------------------

		// Integers (whole numbers)
        int numJupiterMoons = 67;
        Debug.Log(numJupiterMoons);
        // These will cause errors:
        // int temperature = 99.5;
        // int bigNumber = 1000000000000;
        
        // Floats (floating decimal points)
        float taxAmount = 0.07f;
        Debug.Log(taxAmount);
		// These will cause errors:
        // float testScore = 92.5;

        // Strings (collections of characters)
        string welcomeMessage = "Perfect is the enemy of good.";
        Debug.Log(welcomeMessage);

        // -- CONCATENATION ----------------------------------------------------
        
        Debug.Log("Jupiter has " + numJupiterMoons + " moons.");     
	}
	
}
