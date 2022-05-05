using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Howl : MonoBehaviour
{

    public int damage = 1;
    public float speed = 20f;
    public Rigidbody2D rb;

    void Start(){
        rb.velocity = -transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo){
        
        PlayerController player = hitInfo.GetComponent<PlayerController>();
        if(player != null)
        {
            player.TakeHit(damage);
            Destroy(gameObject);
        }
        

        
    }



}