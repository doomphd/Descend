using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApolloBehaviour : MonoBehaviour
{
    private float next1 = 0;
    private float next2 = 0;

    public Transform AttackPoint1;
    public Transform AttackPoint2;

    
    public AIPlayerDetector Detected;

    public GameObject abilityPrefab;
    Animator animator;

    
   void Awake(){
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Detected.PlayerDetected == true){
            if(Time.time > next1){

                Activate1();
                next1 = Time.time + Random.Range(3,7);
            
        }
            if(Time.time > next2){

                Activate2();
                next2 = Time.time + Random.Range(1,5);
            
        }
 
       }
    }

    void Activate1()
    {
        animator.SetTrigger("Attack");
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Apollo/Apollo_Attack", GetComponent<Transform>().position);

        Instantiate(abilityPrefab, AttackPoint1.position, AttackPoint1.rotation);


    }
       void Activate2()
    {
        animator.SetTrigger("Attack");
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Apollo/Apollo_Attack", GetComponent<Transform>().position);

        Instantiate(abilityPrefab, AttackPoint2.position, AttackPoint2.rotation);


    } 
    

}