using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerScript : MonoBehaviourPunCallbacks
{

    [SerializeField]
    GameObject FPSCamera;

    // Start is called before the first frame update
    void Start()
    {
        if(photonView.IsMine){
            transform.GetComponent<PlayerMovement>().enabled = true;
            FPSCamera.GetComponent<Camera>().enabled = true;

        }else{
            transform.GetComponent<PlayerMovement>().enabled = false;
            FPSCamera.GetComponent<Camera>().enabled = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
