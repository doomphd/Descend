using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApolloBehaviour : MonoBehaviour
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

    

    // Start is called before the first frame update
    void Start() {

    }

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
        //animator.SetTrigger("Attack");

        Instantiate(abilityPrefab, AttackPoint1.position, AttackPoint1.rotation);


    }
       void Activate2()
    {
        //animator.SetTrigger("Attack");

        Instantiate(abilityPrefab, AttackPoint2.position, AttackPoint2.rotation);


    } 
    

}