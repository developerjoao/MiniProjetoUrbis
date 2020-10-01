using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaboratorySignpost : SignpostInteract
{
    public override void Interact(GameObject player)
    {
        if(!constructed){
            base.Interact(player);
            canvas.TONLab();
        }
    }

    public void BuildLab(){
        if (gameManager.CanBuildLab()){
            canvas.TOFFLab();
            constructed = true;
        }
    }

    public void CancelLab(){
        unit.SetActive(false);
    }
}
