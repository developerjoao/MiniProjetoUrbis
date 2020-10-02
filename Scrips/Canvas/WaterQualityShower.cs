using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterQualityShower : MonoBehaviour
{
    public GameManager gameManager;
    public float wqValue;
    public TMP_Text wqShower;
    void Update(){
        wqValue = gameManager.GetWaterFinal();
        wqShower.SetText((100*wqValue).ToString()+ " %");
    }
}
