using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PortalScript : MonoBehaviour
{
    public GameObject player;
    public GameObject portal;
    public GameObject stageButton;
    private bool buttonClicked;
    // private bool exitedApolloWorld = false;

    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name != "Tutorial"){
            portal.SetActive(false);
            buttonClicked = false;
        }
        else{
            portal.SetActive(true);

        }

        if(SceneManager.GetActiveScene().name == "Level_1" && VariableManager.exitedApolloWorld == true){
            portal.SetActive(true);
            if(VariableManager.playerXPosition != 0 || VariableManager.playerYPosition != 0){
                transform.position = new Vector3(VariableManager.playerXPosition, VariableManager.playerYPosition , 0);

            }
        }

      
    }


    public void MakePortalAppear(){
        Debug.Log("The button has been clicked");
        portal.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D otherObject){
        // Debug.Log("Collision with portal just happened!!!!!");

        // if(SceneManager.GetActiveScene().name == "Tutorial" || SceneManager.GetActiveScene().name == "Apollo"){
        //     SceneManager.LoadScene()
        // }
        // SceneManager.LoadScene(0);

    }


    public void OnPointerDown(PointerEventData eventData){
        buttonClicked = true;
        Debug.Log("The button has been clicked in PointerDown");

    }

    public void OnCollisionEnter2D(Collision2D otherObject){
       if(SceneManager.GetActiveScene().name == "Tutorial"){
           VariableManager.exitedApolloWorld = true;
        //    VariableManager.playerXPosition = player.transform.position.x;
        //    VariableManager.playerYPosition = player.transform.position.y;
           SceneManager.LoadScene("Level_1");
        }

        if(SceneManager.GetActiveScene().name == "Apollo"){
            SceneManager.LoadScene("Level_1");
       }




       if(SceneManager.GetActiveScene().name == "Level_1"){
            SceneManager.LoadScene("Hades_World");
       }

    }

}

