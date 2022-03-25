using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    public Transform player;
    void Update () 
    {
        transform.position = new Vector3 (player.position.x + 5, player.position.y + 5, -5); 
    }
}
