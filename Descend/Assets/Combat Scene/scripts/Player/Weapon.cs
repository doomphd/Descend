using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float cd = 10;
    private float next = 0;
    public Transform AttackPoint;
    public GameObject abilityPrefab;
    Animator animator;

    

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Time.time > next){
            if(Input.GetButtonDown("Fire1"))
            {
                Activate();
                next = Time.time + cd;
            }
        }
    }

    void Activate()
    {
        //animator.SetTrigger("Attack");

        Instantiate(abilityPrefab, AttackPoint.position, AttackPoint.rotation);
    }
}   