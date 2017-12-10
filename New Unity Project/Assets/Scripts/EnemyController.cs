using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

	public float lookRadius = 10f;

	Transform target;
	NavMeshAgent navAgent;
	CharacterCombat combat;

	void Start () 
	{
		target = PlayerManager.instance.player.transform;
		navAgent = GetComponent<NavMeshAgent> ();
		combat = GetComponent<CharacterCombat> ();
	}

	void Update () 
	{
		float distance = Vector3.Distance (target.position, transform.position);

		if (distance <= lookRadius)
		{
			navAgent.SetDestination (target.position); 

			if (distance <= navAgent.stoppingDistance)
			{
				CharacterStats targetStats = target.GetComponent<CharacterStats> ();
				if (targetStats != null) 
				{
					combat.Attack (targetStats);
				}
				FaceTarget ();
			}
		}
	}

	void FaceTarget ()
	{
		Vector3 direction = (target.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation (new Vector3 (direction.x, 0, direction.z));
		transform.rotation = Quaternion.Slerp (transform.rotation, lookRotation, Time.deltaTime * 5f);
	}

	void OnDrawGizmosSelected ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, lookRadius);
	}
}
