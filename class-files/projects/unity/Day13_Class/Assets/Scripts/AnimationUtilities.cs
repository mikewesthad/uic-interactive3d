using UnityEngine;
using System.Collections;

public static class AnimationUtilities {

	public static float MappedPingPong(float duration, float min, float max) {
		// Use time to find a ping pong value (between 0 and duration)
		float pingPongTime = Mathf.PingPong(Time.time, duration);
		// Now, we want a value between 0 and 1 - so divide by duration
		float lerpAmount = pingPongTime / duration;
		// Use the value between 0 and 1 to find a value between min and max
		float mappedValue = Mathf.Lerp(min, max, lerpAmount);
		return mappedValue;
	}

	public static Color MappedPingPong(float duration, Color min, Color max) {
		float pingPongTime = Mathf.PingPong(Time.time, duration);
		float lerpAmount = pingPongTime / duration;
		Color mappedValue = Color.Lerp(min, max, lerpAmount);
		return mappedValue;
	}

	public static float Map(float value, float currentMin, float currentMax, 
		float newMin, float newMax) {
		float percent = (value - currentMin) / (currentMax - currentMin);
		float newValue = percent * (newMax - newMin) + newMin;
		return newValue;
	}

}
