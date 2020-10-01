using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TotalBagShower : MonoBehaviour
{
    public PlayerController player;
    public int totalBagSlugValue;
    public TMP_Text totalBagSlugShower;
    void Update(){
        totalBagSlugValue = player.GetSlugCount();
        totalBagSlugShower.SetText(totalBagSlugValue.ToString());
    }
}
