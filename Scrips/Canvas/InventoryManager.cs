using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject Inventory;

    public bool open = false;
    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown( KeyCode.Tab ) && !open){
            TONInventory();
        }else if( Input.GetKeyDown( KeyCode.Tab ) && open ){
            TOFFInventory();
        }
    }

    void TONInventory(){
        open = true;
        Inventory.SetActive(true);
    }

    void TOFFInventory(){
        open = false;
        Inventory.SetActive(false);
    }
}
