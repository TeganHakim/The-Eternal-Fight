using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPotion : MonoBehaviour
{
  
    public Item item;
    public InventoryBrain Inventory;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Player")
        {
            Destroy(gameObject);
            Inventory.AddItem(item);
            
        } 
    }
}
