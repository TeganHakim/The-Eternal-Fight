
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEditor;

public class ItemSlot : MonoBehaviour
{

    [SerializeField] Image image;

    public InventoryBrain inventory;
    public event Action<Item> OnRightClickEvent;
    public InventoryManager InventoryManager;

    private Item _item;
    public Item item
    {
        get { return _item; }
        set
        {
            _item = value;
            if (_item == null)
            {
                image.enabled = false;
            }
            else
            {
                image.sprite = _item.icon;
                image.enabled = true;
            }
        }
    }
   public void OnClick()
    {
        if (item != null && _item != null)
        {
            item = item;
            InventoryManager.EquipFromInventory(item);
        }
        
    }
    
    protected virtual void OnValidate()
    {
        if (image == null)
        {
            image = GetComponent<Image>();
        }
    }
}
