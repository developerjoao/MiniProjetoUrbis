using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AirQualityShower : MonoBehaviour
{
    public GameManager gameManager;
    public float aqValue;
    public TMP_Text aqShower;
    void Update(){
        aqValue = gameManager.GetAirFinal();
        aqShower.SetText((100*aqValue).ToString()+ " %");
    }
}
