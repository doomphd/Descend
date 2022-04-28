// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SwordSlash : MonoBehaviour
// {

//     public int damage = 5;
//     public float speed = 20f;
//     public Rigidbody2D rb;

//     void Start(){
//         rb.velocity = transform.right * speed;
//     }

//     void OnTriggerEnter2D(Collider2D hitInfo){
//         Enemy enemy = hitInfo.GetComponent<EnemyBehaviour>();
//         if(enemy != null)
//         {
//             enemy.GetComponent<EnemyBehaviour>().TakeHit(attackDamage);
//         }
//         Destroy(gameObject);
//     }


// }