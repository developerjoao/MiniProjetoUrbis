using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPodium : PodiumInteraction
{
    public override void Interact(GameObject player)
    {
        if (player.GetComponent<PlayerController>().GetWaterSlugCount() > 0){
            base.Interact(player);
            player.GetComponent<PlayerController>().LoseWaterSlug();
            Add();
        }
    }

    public float WaterWaterShare(){
        return SlugCountInPodium() * 0.03f;
    }

    public float WaterEnergyShare(){
        return SlugCountInPodium() * -0.02f;
    }
}
