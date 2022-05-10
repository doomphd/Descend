using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PortalScript : MonoBehaviour
{
    public GameObject player;
    public GameObject portal;
    public GameObject nextLevelDialogue;
    public GameObject levelBoss;
    // public Renderer rend;
    private int executed;

    // Start is called before the first frame update
    void Start()
    {
        // if(SceneManager.GetActiveScene().name != "Tutorial"){
        //     portal.SetActive(false);
        //     buttonClicked = false;
        // }
        // else{
        //     portal.SetActive(true);

        // }

        // if(SceneManager.GetActiveScene().name == "Level_1" && VariableManager.exitedApolloCombat == false){
        //     portal.SetActive(false);

        // }

        executed = 0;

        nextLevelDialogue.SetActive(false);
        if(SceneManager.GetActiveScene().name == "Tutorial"){
            if(levelBoss.GetComponent<Cyclops>().cd >= 5){

                GetComponent<Renderer>().enabled = false;
                SendMessage("Stop");
                // GetComponent<FMODUnity.StudioEventEmitter>().Stop();


                Debug.Log("Portal should be off");
            }
        }
        else if(SceneManager.GetActiveScene().name == "Apollo"){
            if(levelBoss.GetComponent<EnemyBehaviour>().MaxHitpoints >= 40){
                // MakePortalDisappear();
                // portal.SetActive(false);
                GetComponent<Renderer>().enabled = false;
                // GetComponent<FMODUnity.StudioEventEmitter>().Stop();
                SendMessage("Stop");


        //         Debug.Log("Portal should be off");
            }
        }
        else if(SceneManager.GetActiveScene().name == "Hades"){
            if(levelBoss.GetComponent<EnemyBehaviour>().MaxHitpoints >= 40){
                // MakePortalDisappear();
                // portal.SetActive(false);
                GetComponent<Renderer>().enabled = false;
                // GetComponent<FMODUnity.StudioEventEmitter>().Stop();
                SendMessage("Stop");
            }
        }
       

        Debug.Log("Music SHould be off");

        // GetComponent<FMOD >().enabled = false;



        if(SceneManager.GetActiveScene().name == "Level_1" && VariableManager.exitedApolloCombat == true){
            portal.SetActive(true);
            nextLevelDialogue.SetActive(true);
            Debug.Log("Tried making prtal apprear");
        }

        // Debug.Log(levelBoss.GetComponent<Cyclops>().cd);



    }

    void Update()
    {
        if(levelBoss == null && executed == 0){
            // MakePortalAppear();
            // Debug.Log("Portal should appear");
            GetComponent<Renderer>().enabled = true;
            GetComponent<FMODUnity.StudioEventEmitter>().Play();
            // SendMessage("Start");

            Debug.Log("Music playing");
            executed++;

        }
        // if(GameObject.Find("levelBoss") != null){
        //     MakePortalDisappear();
        // }
        // else{
        //     MakePortalAppear();
        // }
      
    }



    public void MakePortalAppear(){
        // Debug.Log("The button has been clicked");
        portal.SetActive(true);
    }

    public void MakePortalDisappear(){
        Debug.Log("The button has been clicked");
        portal.SetActive(false);
    }


    public void OnCollisionEnter2D(Collision2D otherObject){
       if(SceneManager.GetActiveScene().name == "Tutorial"){
           SceneManager.LoadScene("Level_1");
        }

        if(SceneManager.GetActiveScene().name == "Apollo"){
            Debug.Log("Set apollo world boolean to true");
            VariableManager.exitedApolloCombat = true;
            SceneManager.LoadScene("Level_1");
       }

       if(SceneManager.GetActiveScene().name == "Level_1"){
            SceneManager.LoadScene("Hades_World");
       }
       if(SceneManager.GetActiveScene().name == "Hades"){
           SceneManager.LoadScene("Congrats");
       }


       if(SceneManager.GetActiveScene().name == "Hades"){
           SceneManager.LoadScene("Congrats");
       }

    }

}

