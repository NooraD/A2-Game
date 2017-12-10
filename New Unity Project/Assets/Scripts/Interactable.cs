using UnityEngine;

public class Interactable : MonoBehaviour {

	public float radius = 10f;
	public Transform interactionTransform;

	public Transform player;
	bool hasInteracted = false;

	public virtual void Interact ()
	{
			//Debug.Log ("Interacting with " + transform.name);
		
	}

	void Start ()
	{
		player = PlayerManager.instance.player.transform;
	}

	void Update ()
	{
		 float distance = Vector3.Distance (player.position, interactionTransform.position);

			if ((distance <= radius) && (Input.GetKeyDown (KeyCode.Q)))
		{
			Interact ();
			}
	}

	void OnDrawGizmosSelected ()
	{
		if (interactionTransform == null) 
		{
			interactionTransform = transform;
		}
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere (interactionTransform.position, radius);
	}
}
