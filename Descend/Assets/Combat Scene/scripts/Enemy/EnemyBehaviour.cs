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
        if(gameObject.tag == "Apollo"){
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Apollo/Apollo_Damaged", GetComponent<Transform>().position);
        }
        if(gameObject.tag == "Cerberus"){
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Cerberus/Cerberus_Damaged", GetComponent<Transform>().position);

        }        
        if(gameObject.tag == "Hades"){
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Hades/Hades_Damaged", GetComponent<Transform>().position);

        }
        if(gameObject.tag == "Cyclops"){
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Cyclops/Cyclops_Damaged", GetComponent<Transform>().position);

        }
        if(gameObject.tag == "Harpy"){
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Harpy/Harpy_Damaged", GetComponent<Transform>().position);
        }        
        if(gameObject.tag == "Minotaur"){
            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Minotaur/Minotaur_Damaged", GetComponent<Transform>().position);

        }
        if (Hitpoints <= 0)
        {
            if(gameObject.tag == "Apollo"){
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Apollo/Apollo_Death", GetComponent<Transform>().position);
            }
            if(gameObject.tag == "Cerberus"){
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Cerberus/Cerberus_Death", GetComponent<Transform>().position);

            }           
            if(gameObject.tag == "Hades"){
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Hades/Hades_Death", GetComponent<Transform>().position);

            }
            if(gameObject.tag == "Cyclops"){
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Cyclops/Cyclops_Death", GetComponent<Transform>().position);

            }
            if(gameObject.tag == "Harpy"){
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Harpy/Harpy_Death", GetComponent<Transform>().position);
            }        
            if(gameObject.tag == "Minotaur"){
                FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Minotaur/Minotaur_Death", GetComponent<Transform>().position);
            }
            GetComponent<BoxCollider2D>().enabled = false;
            animator.SetTrigger("Death");
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