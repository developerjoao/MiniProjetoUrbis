using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slugpedia : MonoBehaviour
{
    public PlayerController player;
    public GameObject slugpedia;

    public GameObject airSlugpedia;
    public GameObject fotonSlugpedia;
    public GameObject gasSlugpedia;
    public GameObject waterSlugpedia;

    public int slugpediaPage = 1;

    public bool open = false;
    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown( KeyCode.L ) && !open){
            TONSlugpedia();
        }else if( Input.GetKeyDown( KeyCode.L ) && open ){
            TOFFSlugpedia();
        }
    }

    void TONSlugpedia(){
        open = true;
        slugpedia.SetActive(true);
        Page1();
    }

    void TOFFSlugpedia(){
        open = false;
        slugpedia.SetActive(false);
    }

    public void Page1(){
        if (player.airSlugFound)
            airSlugpedia.SetActive(true);
        if (player.fotonSlugFound)            
            fotonSlugpedia.SetActive(true);
        if (player.gasSlugFound)
            gasSlugpedia.SetActive(false);
        if(player.waterSlugFound)
            waterSlugpedia.SetActive(false);
    }

    public void Page2(){
        if (player.airSlugFound)
            airSlugpedia.SetActive(false);
        if (player.fotonSlugFound)
            fotonSlugpedia.SetActive(false);
        if (player.gasSlugFound)
            gasSlugpedia.SetActive(true);
        if(player.waterSlugFound)
            waterSlugpedia.SetActive(true);
    }
}
