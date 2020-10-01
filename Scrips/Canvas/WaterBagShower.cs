using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaterBagShower : MonoBehaviour
{
    public PlayerController player;
    public int waterBagSlugValue;
    public TMP_Text waterBagSlugShower;
    void Update(){
        waterBagSlugValue = player.GetWaterSlugCount();
        waterBagSlugShower.SetText(waterBagSlugValue.ToString());
    }
}
