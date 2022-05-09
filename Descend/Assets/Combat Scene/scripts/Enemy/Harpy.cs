using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harpy : MonoBehaviour
{
    public float cd = 2;
    private float next = 0;

    public Transform AttackPoint1;
   
    public AIPlayerDetector Detected;


    public GameObject abilityPrefab;
    Animator animator;
    

    // Start is called before the first frame update

    void Awake(){
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Detected.PlayerDetected == true){

        if(Time.time > next){

                Activate1();
                next = Time.time + cd;
            
        }


    }
    }

    void Activate1()
    {
        animator.SetTrigger("Attack");
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/Enemies/Harpy/Harpy_Attack", GetComponent<Transform>().position);

        Instantiate(abilityPrefab, AttackPoint1.position, AttackPoint1.rotation);
    }

}