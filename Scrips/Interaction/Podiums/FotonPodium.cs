using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FotonPodium : PodiumInteraction
{
    public override void Interact(GameObject player)
    {
        if (player.GetComponent<PlayerController>().GetFotonSlugCount() > 0){
            base.Interact(player);
            player.GetComponent<PlayerController>().LoseFotonSlug();
            Add();
        }
    }

    public float FotonEnergyShare(){
        return SlugCountInPodium() * 0.01f;
    }

    public float FotonAirShare(){
        return SlugCountInPodium() * -0.01f;
    }
}
