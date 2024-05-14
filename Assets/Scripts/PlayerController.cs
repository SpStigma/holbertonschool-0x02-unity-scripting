using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		float movementHorizontal = Input.GetAxis("Horizontal");
		float movementVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(movementHorizontal, 0, movementVertical);

		rb.velocity = new Vector3(movement.x * speed, rb.velocity.y, movementVertical * speed);
	}
}
