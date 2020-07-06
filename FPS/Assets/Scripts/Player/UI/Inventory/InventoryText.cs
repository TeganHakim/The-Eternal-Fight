using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryText : MonoBehaviour
{
    public Text inventoryammo;
    public Text inventoryammo2;
    public Text inventoryammo3;
    public Ammo ammo;
    public Ammo ammo2;
    public Ammo ammo3;


    // Update is called once per frame
    void Update()
    {
        
        inventoryammo.text = "Ammo:" +
            ammo.ammo;
        inventoryammo2.text = "Ammo:" +
            ammo2.ammo;
        inventoryammo3.text = "Ammo:" +
            ammo3.ammo;
    }
}
