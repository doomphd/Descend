using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hades : MonoBehaviour
{
public GameObject Player;
   public float cd = 3;
    private float next = 0;
    public Transform AttackPoint1;
    public Transform AttackPoint2;
    public Transform AttackPoint3;
    public Transform AttackPoint4;


    public GameObject abilityPrefab;
    Animator animator;

    

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
       // if(Player.transform.position.x > 120){
        if(Time.time > next){

                Activate();
                next = Time.time + cd;
            
        }
       // }
    }

    void Activate()
    {
        //animator.SetTrigger("Attack");

        Instantiate(abilityPrefab, AttackPoint1.position, AttackPoint1.rotation);
        Instantiate(abilityPrefab, AttackPoint2.position, AttackPoint2.rotation);
        Instantiate(abilityPrefab, AttackPoint3.position, AttackPoint3.rotation);
        Instantiate(abilityPrefab, AttackPoint4.position, AttackPoint4.rotation);


    }

}