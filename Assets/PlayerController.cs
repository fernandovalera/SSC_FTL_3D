using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private static KeyCode JUMP_KEY = KeyCode.Space;

	public int baseForce = 1000;
	public float accelerationDueToGravity = -100f;

	private float walkSpeed = 10.0f;
	private Rigidbody rigidbody;

	private bool jumpReady = true;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		float horizontalInput = Input.GetAxis ("Horizontal");
		float verticalInput = Input.GetAxis ("Vertical");

		Vector3 force = new Vector3 (
			horizontalInput * baseForce * walkSpeed, 
			rigidbody.mass * accelerationDueToGravity, 
			verticalInput * baseForce * walkSpeed 
		);

		rigidbody.AddRelativeForce (force * Time.deltaTime);

		if (ReadyToJump () && Input.GetKeyDown(JUMP_KEY) == true) {
			Jump ();
		}
	}

	void ReadyToJump() {

	}

	void Jump() {
		return
	}
}
