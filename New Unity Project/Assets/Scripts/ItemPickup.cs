﻿using UnityEngine;

public class ItemPickup : Interactable
{
	public Item item;

	public override void Interact()
	{
		base.Interact ();

		Pickup ();
	}

	void Pickup()
	{
		Debug.Log ("Picking up " + item.name);
		Inventory.instance.Add (item);
		Destroy (gameObject);

	}
}