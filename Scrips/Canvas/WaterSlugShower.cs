using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterSlugShower : MonoBehaviour
{
    public GameManager gameManager;
    public int waterSlugValue;
    public TMP_Text waterSlugShower;
    void Update(){
        waterSlugValue = gameManager.GetWaterSlugValue();
        waterSlugShower.SetText(waterSlugValue.ToString());
    }
}
