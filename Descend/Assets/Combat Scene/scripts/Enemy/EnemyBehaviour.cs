using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public float Hitpoints;
    public float MaxHitpoints = 5;
    Animator animator;
	string currentAnimState;
    public HealthbarBehaviour Healthbar;

    // Start is called before the first frame update


 
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

        if(gameObject.tag == "Apollo"){
            MaxHitpoints = 40;
        }
        if(gameObject.tag == "Cerberus"){
            MaxHitpoints = 40;
        }        
        if(gameObject.tag == "Hades"){
            MaxHitpoints = 100;
        }
        Hitpoints = MaxHitpoints;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);
    }

    // Update is called once per frame
    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);

        if (Hitpoints <= 0)
        {
            animator.SetTrigger("Death");
            GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(Wait());

                    }
  
    }
    	void ChangeAnimationstate(string newState)
	{
		// Stop animation from interrupting itself
		if (currentAnimState == newState) return;

		// Play new animation
		animator.Play(newState);

		// Update current state
		currentAnimState = newState;
	}
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

}