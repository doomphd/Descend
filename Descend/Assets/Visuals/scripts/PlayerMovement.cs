using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	// Components
	Rigidbody2D rb;

	// Player
	float walkSpeed = 4f;
	float speedLimiter = 0.7f;
	float inputHorizontal;
	float inputVertical;

	// Animations and States
	Animator animator;
	string currentAnimState;
	const string WARRIOR_IDLE= "WarriorIdle";
	const string WARRIOR_WALKING= "WarriorWalking";

	void Start()
	{
		rb = gameObject.GetComponent<Rigidbody2D>();
		animator = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		inputHorizontal = Input.GetAxisRaw("Horizontal");
		inputVertical = Input.GetAxisRaw("Vertical");
	}

	void FixedUpdate()
	{
		if (inputHorizontal != 0 || inputVertical != 0)
		{
			if (inputHorizontal != 0 && inputVertical != 0)
			{
				inputHorizontal *= speedLimiter;
				inputVertical *= speedLimiter;
			}
			rb.velocity = new Vector2(inputHorizontal * walkSpeed, inputVertical * walkSpeed);
			ChangeAnimationstate(WARRIOR_WALKING);
		}
		else
		{
			rb.velocity = new Vector2(0f, 0f);
			ChangeAnimationstate(WARRIOR_IDLE);
		}
	}

	// Animation state changer
	void ChangeAnimationstate(string newState)
	{
		// Stop animation from interrupting itself
		if (currentAnimState == newState) return;

		// Play new animation
		animator.Play(newState);

		// Update current state
		currentAnimState = newState;
	}
}