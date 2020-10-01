using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasSlug : SlugInteraction
{
    public override void Interact(GameObject player)
    {
        PlayerController playerInfo = player.GetComponent<PlayerController>();
        if(playerInfo.GetSlugCount() < 20){
            base.Interact(player);
            playerInfo.AddGasSlug();
            Destroy(gameObject);
        }
    }
}
