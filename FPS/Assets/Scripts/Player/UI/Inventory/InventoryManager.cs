using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryManager : MonoBehaviour
{
    public InventoryBrain inventory;
    public PlayerHealth health;

    

    public void EquipFromInventory(Item item)
    {
        if (item is EquippableItem)
        {
            Equip((EquippableItem)item);
            inventory.RemoveItem(item);
        }
        else
        {
            Use(item);
            inventory.RemoveItem(item);
        }
    }
    private void Equip(EquippableItem item)
    {
        Debug.Log("Equipping " + item + "...");
        if (item.EquipmentType == EquipmentType.ChestPlate) 
        {
            Equip_EquippableItem(item);
        }
        if (item.EquipmentType == EquipmentType.Helmet)
        {
            Equip_EquippableItem(item);
        }
    }

    private void Equip_EquippableItem(EquippableItem item)
    {
        Debug.Log("Eqipped " + item);
    }

    private void Use(Item item)
    {
        Debug.Log("Using " + item + "...");
        if (item.ItemName == "Health Potion")
        {
            health.currentHealth += 10;
            health.healthbar.SetHeath(health.currentHealth);
        }

    }
}
