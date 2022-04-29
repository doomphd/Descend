using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PortalScript : MonoBehaviour
{

    public GameObject portal;
    public GameObject stageButton;
    private bool buttonClicked;
    // Start is called before the first frame update
    void Start()
    {
        portal.SetActive(false);
        buttonClicked = false;

    }

    public void MakePortalAppear(){
        Debug.Log("The button has been clicked");
        portal.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D otherObject){
        Debug.Log("Collision with portal just happened!!!!!");
        SceneManager.LoadScene(4);

    }

    public void OnPointerDown(PointerEventData eventData){
        buttonClicked = true;
        Debug.Log("The button has been clicked in PointerDown");

    }

}

