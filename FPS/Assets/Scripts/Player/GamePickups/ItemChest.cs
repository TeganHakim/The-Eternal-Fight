using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChest : MonoBehaviour
{
    [SerializeField] Item item;
    [SerializeField] InventoryBrain inventory;
    [SerializeField] Color emptyColor;
    [SerializeField] KeyCode itemPickupKeyCode = KeyCode.F;
    [SerializeField] SpriteRenderer spriteRenderer;

    private bool IsInRange;
    private bool isEmpty;
    public Sprite spritehealth;

    private void OnValidate()
    {
        if (inventory == null)
            inventory = FindObjectOfType<InventoryBrain>();

        if (spriteRenderer == null)
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();


        spriteRenderer.sprite = spritehealth;
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsInRange && Input.GetKeyDown(itemPickupKeyCode))
        {
            if (!isEmpty)
            {

                inventory.AddItem(item);
                isEmpty = true;
                spriteRenderer.color = emptyColor;
            }
            
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IsInRange = true;
            spriteRenderer.enabled = true;
        }
        

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IsInRange = false;
            spriteRenderer.enabled = false;
        }
        
    }
}
