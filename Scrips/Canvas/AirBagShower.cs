using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AirBagShower : MonoBehaviour
{
    public PlayerController player;
    public int airBagSlugValue;
    public TMP_Text airBagSlugShower;
    void Update(){
        airBagSlugValue = player.GetAirSlugCount();
        airBagSlugShower.SetText(airBagSlugValue.ToString());
    }
}
