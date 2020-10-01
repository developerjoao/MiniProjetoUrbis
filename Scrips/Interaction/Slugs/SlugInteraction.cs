using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlugInteraction : InteractableObject
{
    public override void Interact(GameObject player)
    {
        player.GetComponent<PlayerController>().AddSlug();
    }
}
