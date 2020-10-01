using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialInstructions : MonoBehaviour
{
    public GameObject initialInfo;
    public GameObject tutorial;
    public GameObject slugTutorial;
    public GameObject buildingTutorial;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void Continue(){
        initialInfo.SetActive(false);
        tutorial.SetActive(true);
    }

    public void ShowTutorial(){
        tutorial.SetActive(false);
        slugTutorial.SetActive(true);
    }

    public void ShowBuildingTutorial(){
        slugTutorial.SetActive(false);
        buildingTutorial.SetActive(true);    
    }

    public void StartGame(){
        buildingTutorial.SetActive(false);
        Time.timeScale = 1;
    }
}
