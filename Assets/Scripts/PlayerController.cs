using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rb;

	float xInput;

	Vector2 newPosition;

	public float moveSpeed;

	public float xPositionLimit;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();

	}
	// Use this for initialization
	void Start () {
		
	}

	

	private void FixedUpdate()
	{
		MovePlayer();
	}

	void MovePlayer()
	{
		//xInput = Input.GetAxis ("Horizontal");
		xInput = CrossPlatformInputManager.GetAxis ("Horizontal");
		newPosition = transform.position;
		newPosition.x += xInput * moveSpeed;

		newPosition.x = Mathf.Clamp (newPosition.x, -xPositionLimit, xPositionLimit);

		rb.MovePosition (newPosition);

	}
}
