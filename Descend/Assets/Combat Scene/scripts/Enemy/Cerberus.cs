using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerberus : MonoBehaviour
{
    private float next1 = 0;
    private float next2 = 0;
    private float next3 = 0;

    public Transform AttackPoint1;
    public Transform AttackPoint2;
    public Transform AttackPoint3;

    
    public AIPlayerDetector Detected;


    public GameObject abilityPrefab;
    Animator animator;

    
    void Awake(){
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        if(Detected.PlayerDetected == true){
            if(Time.time > next1){

                Activate1();
                next1 = Time.time + Random.Range(2,10);
            
        }
            if(Time.time > next2){

                Activate2();
                next2 = Time.time + Random.Range(2,10);
            
        }
            if(Time.time > next3){

                Activate3();
                next3 = Time.time + Random.Range(2,10);
            
        }
       }
    }

    void Activate1()
    {
        animator.SetTrigger("Attack1");

        Instantiate(abilityPrefab, AttackPoint1.position, AttackPoint1.rotation);


    }
       void Activate2()
    {
        animator.SetTrigger("Attack2");

        Instantiate(abilityPrefab, AttackPoint2.position, AttackPoint2.rotation);


    }   void Activate3()
    {
        animator.SetTrigger("Attack3");

        Instantiate(abilityPrefab, AttackPoint3.position, AttackPoint3.rotation);


    }

}