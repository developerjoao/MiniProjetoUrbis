using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnergyShower : MonoBehaviour
{
    public GameManager gameManager;
    public float eValue;
    public TMP_Text eShower;
    void Update(){
        eValue = gameManager.GetEnergyFinal();
        eShower.SetText((100*eValue).ToString()+ " %");
    }
}
