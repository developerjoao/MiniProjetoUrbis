using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CycleShower : MonoBehaviour
{
    public GameManager gameManager;
    public float timerValue;
    public TMP_Text timeShower;
    void Update(){
        timerValue = gameManager.GetTimer();
        timeShower.SetText(timerValue.ToString());
    }
}
