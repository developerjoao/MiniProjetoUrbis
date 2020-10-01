using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSlug : SlugInteraction
{
    public override void Interact(GameObject player)
    {
        PlayerController playerInfo = player.GetComponent<PlayerController>();
        if(playerInfo.GetSlugCount() < 20){
            base.Interact(player);
            playerInfo.AddWaterSlug();
            Destroy(gameObject);
        }
    }
}
