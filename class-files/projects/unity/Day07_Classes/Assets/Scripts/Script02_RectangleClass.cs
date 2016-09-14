using UnityEngine;
using System.Collections;
using Debug = ClassUtilities.Debug; // <- Ignore this! For class demos only

public class Script02_RectangleClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rectangle rectangle1 = new Rectangle(10f, 20f);
		Debug.Log("Rectangle 1's area: " + rectangle1.GetArea());
		Debug.Log("Rectangle 1's perimeter: " + rectangle1.GetPerimeter());

		Rectangle rectangle2 = new Rectangle(5.5f, 7f);
		Debug.Log("Rectangle 2's area: " + rectangle2.GetArea());
		Debug.Log("Rectangle 2's perimeter: " + rectangle2.GetPerimeter());
	}
}

// Create a Rectangle class:
// 	- It should have public fields for Width & Height
// 	- It should have a constructor that can initialize the Width and Height
// 	- It should have a method GetArea that returns a float
//	- It should have a method GetPerimeter that returns a float
// 
// Test it by creating a couple Rectangle instances and calculating the area
// and perimeter

public class Rectangle {
	// Fields
	public float Width;
	public float Height;

	// Constructor
	public Rectangle(float width, float height) {
		Width = width;
		Height = height;
	}

	// Method
	public float GetArea() {
		float area = Width * Height;
		return area;
	}
	public float GetPerimeter() {
		float perimeter = 2f * (Width + Height);
		return perimeter;
	}
}