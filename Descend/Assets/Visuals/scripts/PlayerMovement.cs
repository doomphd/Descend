using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class PlayerMovement : MonoBehaviour {

// 	Rigidbody2D body;

// 	float horizontal;
// 	float vertical;
// 	float moveLimiter = 0.7f;

// 	public float runSpeed = 20.0f;

// 	void Start ()
// 	{
// 		body = GetComponent<Rigidbody2D>();
// 	}

// 	void Update()
// 	{
// 		// Gives a value between -1 and 1
// 		horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
// 		vertical = Input.GetAxisRaw("Vertical"); // -1 is down
// 	}

// 	void FixedUpdate()
// 	{
// 	if (horizontal != 0 && vertical != 0) // Check for diagonal movement
// 	{
// 		// limit movement speed diagonally, so you move at 70% speed
// 		horizontal *= moveLimiter;
// 		vertical *= moveLimiter;
// 	} 

// 	body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
// 	}
// }



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