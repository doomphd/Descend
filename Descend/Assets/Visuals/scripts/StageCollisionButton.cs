using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageCollisionButton : MonoBehaviour
{
    public GameObject button;
    public Canvas canvas;

    private void Start(){
        button.SetActive(false);
        canvas.worldCamera = Camera.main;
    }

    private void OnTriggerEnter2D(Collider2D otherObject){
        Debug.Log("Collision");
        Debug.Log("Player/Emblem Collision");
        button.SetActive(true); 
    }

    private void OnTriggerExit2D(Collider2D otherObject){
        button.SetActive(false);
    }


  

}
