using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherBasic : MonoBehaviour
{
    public float cd = 1/2;
    private float next = 0;
    public Transform AttackPoint;
    public GameObject attackPrefab;
    Animator animator;

    

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Time.time > next){
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Activate();
                next = Time.time + cd;
            }
        }
    }

    void Activate()
    {
        //animator.SetTrigger("Attack");

        Instantiate(attackPrefab, AttackPoint.position, AttackPoint.rotation);
    }
}   