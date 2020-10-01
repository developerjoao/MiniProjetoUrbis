using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcademySignpost : SignpostInteract
{
    public override void Interact(GameObject player)
    {
        if(!constructed){
            base.Interact(player);
            canvas.TONAcad();
        }
    }

    public void BuildAcad(){
        if( gameManager.CanBuildAcademy() ){
            canvas.TOFFAcad();
            constructed = true;
        }
    }

    public void CancelAcad(){
        unit.SetActive(false);
    }
}
