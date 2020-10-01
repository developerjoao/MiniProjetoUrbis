using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatueSignpost : SignpostInteract
{
    public override void Interact(GameObject player)
    {
        if(!constructed){
            base.Interact(player);
            canvas.TONStatue();
        }
    }

    public void BuildStatue(){
        if( gameManager.CanBuildStatue() ){
            canvas.TOFFStatue();
            constructed = true;       
        }
    }

    public void CancelStatue(){
        unit.SetActive(false);
    }
}
