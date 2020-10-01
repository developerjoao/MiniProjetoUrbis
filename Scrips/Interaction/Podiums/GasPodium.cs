using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasPodium : PodiumInteraction
{
    public override void Interact(GameObject player)
    {
        if (player.GetComponent<PlayerController>().GetGasSlugCount() > 0){
            base.Interact(player);
            player.GetComponent<PlayerController>().LoseGasSlug();
            Add();
        }
    }

    public float GasEnergyShare(){
        return SlugCountInPodium() * 0.05f;
    }

    public float GasAirShare(){
        return SlugCountInPodium() * -0.03f;
    }
}
