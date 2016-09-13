using UnityEngine;
using System.Collections;

public class LightColorSwitcher : MonoBehaviour {

	public float MouseSensitivityX = 0.02f;
	public float MouseSensitivityY = 0.02f;

	private Light LightComponent;

	private float RedAmount = 0f;
	private float BlueAmount = 0f;

	void Start () {
		// Gets access to the light component on the game object. This only
		// works if the script is attached to a light!
		LightComponent = GetComponent<Light>();
	}

	void Update () {
		// Changes the light's color to red using RGB
		// - First parameter is the amount of red color (between 0f and 1f)
		// - Second parameter is the amount of green color (between 0f and 1f)
		// - Third parameter is the amount of blue color (between 0f and 1f)
//		LightComponent.color = new Color(1f, 0f, 0f);

		// Changing the color when a number is pressed
		if (Input.GetKey("1")) {
			LightComponent.color = new Color(1f, 0f, 1f);
		} else if (Input.GetKey("2")) {
			LightComponent.color = new Color(1f, 1f, 0f);
		} else if (Input.GetKey("3")) {
			LightComponent.color = new Color(0f, 1f, 1f);
		}

		// Using the mouse movement to drive the color of the light
		RedAmount += Input.GetAxis("Mouse X") * MouseSensitivityX;
		if (RedAmount < 0f) {
			RedAmount = 0f;
		} else if (RedAmount > 1f) {
			RedAmount = 1f;
		}
		BlueAmount += Input.GetAxis("Mouse Y") * MouseSensitivityY;
		if (BlueAmount < 0f) {
			BlueAmount = 0f;
		} else if (BlueAmount > 1f) {
			BlueAmount = 1f;
		}
		LightComponent.color = new Color(RedAmount, 0f, BlueAmount);
	}
}