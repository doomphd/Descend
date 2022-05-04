using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSlash : MonoBehaviour
{

    public int damage = 5;
    public float speed = 20f;
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
        private IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }


}