using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	public LayerMask groundLayers;
	public float jumpForce;
	public CapsuleCollider col;
	Camera cam;






	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		Cursor.lockState = CursorLockMode.Locked;
		col = GetComponent<CapsuleCollider> ();
		cam = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {

		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, translation);

		if (IsGrounded () && Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);

		}

		if (Input.GetKeyDown ("escape")) {
				
				Cursor.lockState = CursorLockMode.None;
	
		}
			
	}


	bool IsGrounded()
	{
		return Physics.CheckCapsule (col.bounds.center, new Vector3 (col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
	
	}
		
}
