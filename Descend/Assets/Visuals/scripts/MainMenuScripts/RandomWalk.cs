using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWalk : MonoBehaviour 
{
	// // Components
	// Rigidbody2D rb;

	// // Player
	// float speedLimiter = 0.7f;

    // private float timeToChangeDirection;

	// void Start()
	// {
	// 	rb = gameObject.GetComponent<Rigidbody2D>();
    //     ChangeDirection();
	// }

	// // Update is called once per frame
	// void Update()
	// {
    //     timeToChangeDirection -= Time.deltaTime;
 
    //     if (timeToChangeDirection <= 0) 
    //     {
    //         ChangeDirection();
    //     }
 
    //      rb.velocity = transform.up * speedLimiter;
	// }

    // private void ChangeDirection() {
    //      float angle = Random.Range(0f, 360f);
    //      Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
    //      Vector3 newUp = quat * Vector3.up * speedLimiter;
    //      newUp.z = 0;
    //      newUp.Normalize();
    //      transform.up = newUp;
    //      timeToChangeDirection = 5f;
    // }





    Rigidbody2D rb;

	// Player
	float speedLimiter = 1.25f;
	float inputHorizontal;
    int back = 30;

    private float timeToChangeDirection;

	void Start()
	{
		rb = gameObject.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
        System.Random rnd = new System.Random();

		inputHorizontal = rnd.Next(0,2);
	}

	void FixedUpdate()
	{
		if (inputHorizontal != 0)
		{
			rb.velocity = new Vector2(inputHorizontal * speedLimiter, 0);
            back--;
		}
		else
		{
			rb.velocity = new Vector2(0f, 0f);
		}
        if(back == 0)
        {
            ChangeDirection();
            rb.velocity = new Vector2((-inputHorizontal * 45), 0);
            back=30;
        }
	}

    private void ChangeDirection() {
         float angle = Random.Range(0f, 360f);
         Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
         Vector3 newUp = quat * Vector3.up * speedLimiter;
         newUp.z = 0;
         newUp.Normalize();
         transform.up = newUp;
         timeToChangeDirection = 30f;
    }
}