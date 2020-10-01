using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FotonSlugShower : MonoBehaviour
{
    public GameManager gameManager;
    public int fotonSlugValue;
    public TMP_Text fotonSlugShower;
    void Update(){
        fotonSlugValue = gameManager.GetFotonSlugValue();
        fotonSlugShower.SetText(fotonSlugValue.ToString());
    }
}
