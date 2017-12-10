﻿using UnityEngine;

public class CharacterStats : MonoBehaviour 
{
	public int maxHealth = 100;
	public int currentHealth { get; private set; }

	void Awake ()
	{
		currentHealth = maxHealth;
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.T)) 
		{
			TakeDamage (10);
		}
	}

	public void TakeDamage (int damage)
	{
		currentHealth -= damage;
		Debug.Log (transform.name + " takes " + damage + " damage.");

		if (currentHealth <= 0) 
		{
			Die ();
		}
	}

	public virtual void Die()
	{
		//die
		Debug.Log (transform.name + "died.");
	}
}