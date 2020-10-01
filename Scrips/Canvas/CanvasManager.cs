using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasManager : MonoBehaviour
{
    public Image energyDisplay;
    public Image airQualityDisplay;
    public Image waterQualityDisplay;
    //public Image xQualityDisplay;

    public void UpdateEnergyDisplay(float amount){
        if(energyDisplay.fillAmount + amount > 1f){
            energyDisplay.fillAmount = 1f;
        }else{
            energyDisplay.fillAmount += amount;
        }
    }

    public void UpdateAirDisplay(float amount){
        if(airQualityDisplay.fillAmount + amount > 1f){
            airQualityDisplay.fillAmount = 1f;
        }else{
            airQualityDisplay.fillAmount += amount;
        }
    }

    public void UpdateWaterDisplay(float amount){
        if(waterQualityDisplay.fillAmount + amount > 1f){
            waterQualityDisplay.fillAmount = 1f;
        }else{
            waterQualityDisplay.fillAmount += amount;
        }
    }

    public float GetEnergyAmount(){
        return energyDisplay.fillAmount;
    }
    public float GetAirAmount(){
        return airQualityDisplay.fillAmount;
    }
    public float GetWaterAmount(){
        return waterQualityDisplay.fillAmount;
    }

    public GameObject residencialDisplay;
    public void TONResidencial(){
        residencialDisplay.SetActive(true);
    }
    public void TOFFResidencial(){
        residencialDisplay.SetActive(false);
    }

    public GameObject greenhouseDisplay;
    public void TONGH(){
        greenhouseDisplay.SetActive(true);
    }
    public void TOFFGH(){
        greenhouseDisplay.SetActive(false);
    }

    public GameObject farmDisplay;
    public void TONFarm(){
        farmDisplay.SetActive(true);
    }
    public void TOFFFarm(){
        farmDisplay.SetActive(false);
    }

    public GameObject labDisplay;
    public void TONLab(){
        labDisplay.SetActive(true);
    }
    public void TOFFLab(){
        labDisplay.SetActive(false);
    }

    public GameObject statueDisplay;
    public void TONStatue(){
        statueDisplay.SetActive(true);
    }
    public void TOFFStatue(){
        statueDisplay.SetActive(false);
    }

    public GameObject acadDisplay;
    public void TONAcad(){
        acadDisplay.SetActive(true);
    }
    public void TOFFAcad(){
        acadDisplay.SetActive(false);
    }

    public GameObject winDisplay;
    public void ShowWinDisplay(){
        Time.timeScale = 0;
        winDisplay.SetActive(true);
    }
    public GameObject loseDisplay;
    public void ShowLoseDisplay(){
        Time.timeScale = 0;
        loseDisplay.SetActive(true);
    }
}
