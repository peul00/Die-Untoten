using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class InventoryUI : MonoBehaviour
{
    Inventory inven;
    
    public GameObject inventoryPanel;
    bool activeInventory = false;

    public Slot[] slots;
    public Transform slotHolder;
    
    private void Start()
    {
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        inven.onSlotCountChange += SlotChange;
        inventoryPanel.SetActive(activeInventory);
        Debug.Log("start");
    }

    private void SlotChange(int val)
    {
        for(int i = 0; i< slots.Length; i++)
        {
            if(i < inven.SlotCnt)
            {
                slots[i].GetComponent<Button>().interactable = true;
            }
            else
            {
                slots[i].GetComponent<Button>().interactable = false;
            }
        }
    }

    void Update()
    {
        Debug.Log("update");
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("2");
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);
        }
    }
    


    public void AddSlot()
    {
        inven.SlotCnt++;
    }
}
