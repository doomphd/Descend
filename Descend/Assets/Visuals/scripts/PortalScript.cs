using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PortalScript : MonoBehaviour
{
    public GameObject player;
    public GameObject portal;

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

        if(SceneManager.GetActiveScene().name == "Level_1" && VariableManager.exitedApolloCombat == true){
            portal.SetActive(true);
            Debug.Log("Tried making prtal apprear");
        }


        // if(SceneManager.GetActiveScene().name != "Tutorial"){
        //     portal.SetActive(true);
            
        // }
      
    }

    // void Update(){
    //     if(SceneManager.GetActiveScene().name == "Apollo"){
    //         VariableManager.exitedApolloWorld = true;
    //     }
    // }


    public void MakePortalAppear(){
        Debug.Log("The button has been clicked");
        portal.SetActive(true);
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

