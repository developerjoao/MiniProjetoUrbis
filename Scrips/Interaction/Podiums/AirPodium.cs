using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPodium : PodiumInteraction
{
    public override void Interact(GameObject player)
    {
        if (player.GetComponent<PlayerController>().GetAirSlugCount() > 0){
            base.Interact(player);
            player.GetComponent<PlayerController>().LoseAirSlug();
            Add();
        }
    }

    public float AirEnergyShare(){
        return SlugCountInPodium() * -0.01f;
    }

    public float AirAirShare(){
        return SlugCountInPodium() * 0.01f;
    }
}
