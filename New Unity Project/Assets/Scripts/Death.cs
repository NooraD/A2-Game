using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : CharacterStats {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public override void Die()
	{
		base.Die();
		PlayerManager.instance.KillPlayer();
	}
}