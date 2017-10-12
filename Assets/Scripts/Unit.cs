using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

	// Public attribute;
	public string name;
	public string type;
	public int health;
	public int meleeAttack;		// All units will have the ability to attack adjascent enemies
	public int movementRange;
	public int attackRange;

	// Private attributes
	private int cooldown;
	private Tile currentlyOn;

	void Start()
	{
		
	}
	
	void Update()
	{
		
	}
	
	void AttemptMove(Vector3 position)
	{
		// Check if Unit can move to selected Tile
		// Look for other Units already on that Tile
	}

	void SeeRange()
	{
		// Attach an event here
		// Find tiles within range of player
		// Could use 
	}

	void Attack()
	{
		// An event will probably need to be attached here to attack a target Unit
		// Deal meleeAttack damage
	}
	
	void Capture()
	{
		// An event is needed here as well
	}

	void TakeDamage(int damageAmount)
	{
		health += damageAmount;
	}

	void Heal(int healAmount)
	{
		health -= healAmount;
	}

	void Die()
	{
		// Maybe attach an event here...
		Destroy(gameObject);
	}
}
