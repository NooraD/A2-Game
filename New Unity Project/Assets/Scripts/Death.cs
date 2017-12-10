using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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