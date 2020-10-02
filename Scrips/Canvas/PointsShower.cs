using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsShower : MonoBehaviour
{
    public PlayerController player;
    public float pointValue;
    public TMP_Text pointShower;
    void Update(){
        pointValue = player.GetPoints();
        pointShower.SetText(pointValue.ToString());
    }
}
