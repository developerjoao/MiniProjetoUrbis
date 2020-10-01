using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GasBagShower : MonoBehaviour
{
    public PlayerController player;
    public int gasBagSlugValue;
    public TMP_Text gasBagSlugShower;
    void Update(){
        gasBagSlugValue = player.GetGasSlugCount();
        gasBagSlugShower.SetText(gasBagSlugValue.ToString());
    }
}
