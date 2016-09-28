using UnityEngine;
using System.Collections;

public class WarmupLoops : MonoBehaviour {

	public GameObject Pikachu;

	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < 20; i += 1) {
			Vector3 pos = new Vector3(i * 2f, 0f, 0f);
			Quaternion rot = Quaternion.Euler(i * 10, 0f, 0f);
			GameObject clonedPikachu = (GameObject) Instantiate(Pikachu, pos, rot, transform);
			Material mat = clonedPikachu.GetComponent<MeshRenderer>().material;
			mat.color = Color.HSVToRGB(i / 19f, 1f, 1f);
		}			

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
