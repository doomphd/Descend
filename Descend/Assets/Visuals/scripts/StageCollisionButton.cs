using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StageCollisionButton : MonoBehaviour
{
    public GameObject dialogueButton;
    public Text buttonText;
    public Canvas dialogueCanvas;
    public GameObject button;
    public Canvas canvas;
    private int sentenceTracker;
    private string [] sentences = {"You made it!", "I'm so glad you are here. I thought we were all DOOMED.", 
                     "That troublesome Hades is at it again. Can you help us?", "Too late you're already here.",
                     "Well? What are you waiting for! Get to it!"};

    private void Start(){
        button.SetActive(false);
        canvas.worldCamera = Camera.main;
        dialogueCanvas.worldCamera = Camera.main;        
        sentenceTracker = 0;
        dialogueButton.SetActive(false);
    }

    private void onMouseDown(){
        
    }

     private void NoParamaterOnclick()
    {
        buttonText.text = sentences[sentenceTracker];
        sentenceTracker++;
        
        Debug.Log("Button clicked with no parameters");
    }

    private void OnTriggerEnter2D(Collider2D otherObject){
        Debug.Log("Collision");
        Debug.Log("Player/Emblem Collision");
        button.SetActive(true); 
        // dialogueButton.SetActive(true);

    }

    private void OnTriggerExit2D(Collider2D otherObject){
        button.SetActive(false);
        // dialogueButton.SetActive(true);

    }


  

}
