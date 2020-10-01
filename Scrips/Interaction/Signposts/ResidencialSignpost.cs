using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResidencialSignpost : SignpostInteract
{
    public override void Interact(GameObject player)
    {
        if(!constructed){
            base.Interact(player);
            canvas.TONResidencial();
        }
    }

    public void BuildResidencial(){
        if (gameManager.CanBuildResidencial() ){
            canvas.TOFFResidencial();
            constructed = true;
        }
    }

    public void CancelResidencial(){
        unit.SetActive(false);
    }
}
