using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopSlot : MonoBehaviour, IPointerUpHandler
{
    public int slotnum;
    public Item item;
    public Image itemIcon;
    public bool soldOut = false;


    public void UpdateSlotUI()
    {
        itemIcon.sprite = item.itemImage;
        itemIcon.gameObject.SetActive(true);
    }
    public void RemoveSlot()
    {
        item = null;
        itemIcon.gameObject.SetActive(false);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (item != null)
        {
            if(ItemDatabase.instance.Money >= item.ItemCost && !soldOut)
            {
                ItemDatabase.instance.Money -= item.ItemCost;
                Inventory.instance.AddItem(item);
            }
        
            

        }
    }
    
}