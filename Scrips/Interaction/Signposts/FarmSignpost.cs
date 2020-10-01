using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmSignpost : SignpostInteract
{
    public override void Interact(GameObject player)
    {
        if(!constructed){
            base.Interact(player);
            canvas.TONFarm();
        }
    }

    public void BuildFarm(){
        if ( gameManager.CanBuildFarm() ){
            canvas.TOFFFarm();
            constructed = true;
        }
    }

    public void CancelFarm(){
        unit.SetActive(false);
    }
}
