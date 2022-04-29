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
    private int hadesSentenceTracker;
    private string [] apolloSentences = {"x", "y", "z"};
    private string [] hadesSentences = {"1", "2", "3"};


    private bool buttonClicked = false;
    public GameObject portal;

    private void Start(){
        button.SetActive(false);
        canvas.worldCamera = Camera.main;
        dialogueBox.SetActive(false);
        sentenceTracker = 0;
        hadesSentenceTracker = 0;
        portal.SetActive(false);


        
        // dialogueButton.SetActive(false);
    }
    
    void Update()
    {
        if (Input.GetKeyDown("space") && buttonClicked == true)
        {
            if(SceneManager.GetActiveScene().name == "Level_1"){
                ApolloDialogue();

            }
            else{
                HadesDialogue();
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D otherObject){
        Debug.Log("Collision");
        Debug.Log("Player/Emblem Collision");
        button.SetActive(true); 

    }

    private void OnTriggerExit2D(Collider2D otherObject){
        button.SetActive(false);

    }

    public void ApolloDialogue(){

        buttonClicked = true;
        button.SetActive(false);

        if(sentenceTracker < apolloSentences.Length){

            dialogueBox.SetActive(true);
            dialogue.text = apolloSentences[sentenceTracker];
            sentenceTracker++;

        }
        else{
            portal.SetActive(true);
            SceneManager.LoadScene(0);
            buttonClicked = false;
            dialogue.text = "";


        }
    }
    
    public void HadesDialogue(){

        buttonClicked = true;
        button.SetActive(false);


        if(hadesSentenceTracker < hadesSentences.Length){

            dialogueBox.SetActive(true);
            dialogue.text = hadesSentences[hadesSentenceTracker];
            hadesSentenceTracker++;

        }
        else{
            SceneManager.LoadScene(5);
        }
    }



}
