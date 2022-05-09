using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public int damage = 1;
    public float speed = 10f;
    public Rigidbody2D rb;

    void Start(){
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo){
        
        EnemyBehaviour enemy = hitInfo.GetComponent<EnemyBehaviour>();
        if(enemy != null)
        {
            enemy.TakeHit(damage);
            Destroy(gameObject);
        }
        
    }


}