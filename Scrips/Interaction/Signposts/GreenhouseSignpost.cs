using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenhouseSignpost : SignpostInteract
{
    public override void Interact(GameObject player)
    {
        if(!constructed){
            base.Interact(player);
            canvas.TONGH();
        }
    }

    public void BuildGH(){
        if (gameManager.CanBuildGH() ){
            canvas.TOFFGH();
            constructed = true;   
        }
    }

    public void CancelGH(){
        unit.SetActive(false);
    }
}
