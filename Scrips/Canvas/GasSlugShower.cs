using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GasSlugShower : MonoBehaviour
{
    public GameManager gameManager;
    public int gasSlugValue;
    public TMP_Text gasSlugShower;
    void Update(){
        gasSlugValue = gameManager.GetGasSlugValue();
        gasSlugShower.SetText(gasSlugValue.ToString());
    }
}
