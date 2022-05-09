using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PauseMenu : MonoBehaviour {
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } 
            else {
                Pause();
            }
        }
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/UI/Button_Popup", GetComponent<Transform>().position);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    // public void LoadMenu()
    // {
    //     Time.timeScale = 1f;
    //     GameIsPaused = false;
    //     UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    // }

    // public void QuitGame()
    // {
    //     Debug.Log("Quitting game...");
    //     Application.Quit();
    // }
}
