using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApolloBehaviour : MonoBehaviour
{

    public float Hitpoints;
    public float MaxHitpoints = 40;
    public HealthbarBehaviour Healthbar;
    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);
    }

    // Update is called once per frame
    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);


        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
