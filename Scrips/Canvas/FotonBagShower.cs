using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FotonBagShower : MonoBehaviour
{
    public PlayerController player;
    public int fotonBagSlugValue;
    public TMP_Text fotonBagSlugShower;
    void Update(){
        fotonBagSlugValue = player.GetFotonSlugCount();
        fotonBagSlugShower.SetText(fotonBagSlugValue.ToString());
    }
}
