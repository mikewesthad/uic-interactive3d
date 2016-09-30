using UnityEngine;
using System.Collections;

public class RandomlySpawn : MonoBehaviour {

	public GameObject[] PokemonPrefabs;
	public int NumberToSpawn = 100;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < NumberToSpawn; i += 1) {

			int randomIndex = Random.Range(0, PokemonPrefabs.Length - 1);
			GameObject randomPokemon = PokemonPrefabs[randomIndex];

			Vector3 randomPos = new Vector3(
				Random.Range(-20f, 20f),
				0f, 
				Random.Range(-20f, 20f)
			);
			Quaternion randomRot = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
			Instantiate(randomPokemon, randomPos, randomRot, transform);

		}

	}

	// Update is called once per frame
	void Update () {
		
	}
}
