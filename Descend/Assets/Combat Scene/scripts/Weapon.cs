using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform AttackPoint;
    public GameObject abilityPrefab;
    Animator animator;
    

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Activate();
        }
    }

    void Activate()
    {
        //animator.SetTrigger("Attack");

        Instantiate(abilityPrefab, AttackPoint.position, AttackPoint.rotation);
    }
}   