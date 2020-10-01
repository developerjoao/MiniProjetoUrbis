using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodiumInteraction : InteractableObject
{
    [SerializeField]
    protected int slugsInPodium = 0;
    public override void Interact(GameObject player)
    {
        player.GetComponent<PlayerController>().LoseSlug();
    }

    public int SlugCountInPodium(){
        return slugsInPodium;
    }

    protected void Add(){
        slugsInPodium += 1;
    }

    public bool CanBuild(int amount){
        if( slugsInPodium - amount >= 0){
            return true;
        }else{
            return false;
        }
    }

    public void ReduceSlugs(int amount){
        slugsInPodium -= amount;
    }
}
