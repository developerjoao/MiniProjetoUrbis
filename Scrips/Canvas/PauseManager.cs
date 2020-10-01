using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool open = false;

    void Update()
    {
        if( Input.GetKeyDown( KeyCode.Escape ) && !open){
            TONPause();
        }else if( Input.GetKeyDown( KeyCode.Escape ) && open ){
            TOFFPause();
        }
    }

    public void TONPause(){
        open = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void TOFFPause(){
        open = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void QuitGame(){
        Debug.Log("Quitted game");
        Application.Quit();
    }
}
