using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AirSlugShower : MonoBehaviour
{
    public GameManager gameManager;
    public int airSlugValue;
    public TMP_Text airSlugShower;
    void Update(){
        airSlugValue = gameManager.GetAirSlugValue();
        airSlugShower.SetText(airSlugValue.ToString());
    }
}
