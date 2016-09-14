using UnityEngine;
using System.Collections;
using Debug = ClassUtilities.Debug; // <- Ignore this! For class demos only

public class Script01_ClassesDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Enemy enemy1 = new Enemy("Carl the Goblin", 10);
		enemy1.Speak();
		enemy1.SayHealth();
		enemy1.TakeDamage(5);
		enemy1.SayHealth();
		enemy1.TakeDamage(5);
		enemy1.SayHealth();

		Enemy enemy2 = new Enemy("Radcliff", 20);
		enemy2.Speak();
		enemy2.SayHealth();
		enemy2.TakeDamage(5);
		enemy2.SayHealth();
	}

}

public class Enemy {

	// Fields
	public string Name;
	private int Health;

	// Constructor
	public Enemy(string name, int health) {
		Name = name;
		Health = health;
	}

	// Methods
	public void Speak() {
		Debug.Log("Hello, I am " + Name + ".");
	}
	public void SayHealth() {
		if (Health > 0) {
			Debug.Log(Name + ": I have " + Health + " HP.");
		} else {
			Debug.Log(Name + ": I am dead.");
		}
	}
	public void TakeDamage(int damage) {
		Health -= damage;
	}
}