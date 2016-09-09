using UnityEngine;
using System.Collections;

public class EnemyClassDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Enemy enemy1 = new Enemy("Carl the Goblin");
		enemy1.Speak();

		Enemy enemy2 = new Enemy("Radcliff");
		enemy2.Speak();
	}

}

public class Enemy {

	// Fields
	public string Name;

	// Constructor
	public Enemy(string name) {
		Name = name;
	}

	// Methods
	public void Speak() {
		Debug.Log("Hello, I am " + Name + ".");
	}

}