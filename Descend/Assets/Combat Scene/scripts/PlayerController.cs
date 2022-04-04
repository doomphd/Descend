using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float moveSpeed;
    private float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;

    Animator animator;
	string currentAnimState;
	const string WARRIOR_IDLE= "WarriorIdle";
	const string WARRIOR_WALKING= "WarriorWalking";
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();

        moveSpeed = 1.5f;
        jumpForce = 35f;
        isJumping = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
        
    }

    void FixedUpdate() 
    {
        if(moveHorizontal > 0.1f || moveHorizontal < -0.1f){
            ChangeAnimationstate(WARRIOR_WALKING);
            rb2D.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);

        }

        if(!isJumping && moveVertical > 0.1f)
        {
            rb2D.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }
        if(moveHorizontal == 0f && moveVertical == 0f){
			ChangeAnimationstate(WARRIOR_IDLE);

        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            isJumping = false;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Platform")
        {
            isJumping = true;
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
