using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignpostInteract : InteractableObject
{
    public GameManager gameManager;
    public CanvasManager canvas;
    public GameObject unit;
    public bool constructed = false;

    public override void Interact(GameObject player)
    {
        unit.SetActive(true);
    }
}
