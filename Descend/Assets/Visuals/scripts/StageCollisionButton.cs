using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StageCollisionButton : MonoBehaviour
{
    public GameObject dialogueBox;
    public TextMeshProUGUI dialogue;
    // public Canvas dialogueCanvas;
    public GameObject button;
    public Canvas canvas;
    private int sentenceTracker;
    private string [] sentences = {"x", "y", "z"};
    private bool buttonClicked = false;
    public GameObject portal;

    private void Start(){
        button.SetActive(false);
        canvas.worldCamera = Camera.main;
        dialogueBox.SetActive(false);
        // dialogueCanvas.worldCamera = Camera.main;        
        sentenceTracker = 0;
        portal.SetActive(false);


        
        // dialogueButton.SetActive(false);
    }
    
    void Update()
    {
        if (Input.GetKeyDown("space") && buttonClicked == true)
        {
            Dialogue();
        }
    }

    // private void onMouseDown(){
        
    // }

    // private void NoParamaterOnclick()
    // {
    //     buttonText.text = sentences[sentenceTracker];
    //     sentenceTracker++;
        
    //     Debug.Log("Button clicked with no parameters");
    // }

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

    public void Dialogue(){

        buttonClicked = true;
        button.SetActive(false);

        if(sentenceTracker < 3){

            dialogueBox.SetActive(true);
            dialogue.text = sentences[sentenceTracker];
            sentenceTracker++;

        }else{
            portal.SetActive(true);
            SceneManager.LoadScene(0);
        }
    }



    


  

}
