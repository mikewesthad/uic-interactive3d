using UnityEngine;
using System.Collections;

public class LightTrigger : MonoBehaviour {

	public Transform PlayerTransform;
	public float TriggerDistance = 15f;

	public bool IsRangeAnimated = false;
	public float AnimationDuration = 2f;
	public float MinRange = 14f;
	public float MaxRange = 20f;

	private Light LightComponent;

	// Use this for initialization
	void Start () {
		LightComponent = GetComponent<Light>();

		// For turning a light off/on, you can use intensity like we did in 
		// class:
		//	LightComponent.intensity = 0f;
		// Or, you can leave the intensity alone and use the enabled property:
		LightComponent.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		float distance = Vector3.Distance(transform.position, PlayerTransform.position);
		if (distance <= TriggerDistance) {
			LightComponent.enabled = true;

			if (IsRangeAnimated) {
				LightComponent.range = AnimationUtilities.MappedPingPong(AnimationDuration, 
					MinRange, MaxRange);
			}

		} else {
			LightComponent.enabled = false;
		}
	
	}
}
