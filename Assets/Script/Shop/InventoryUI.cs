using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    bool activeInventory = false;

    public Slot[] slots;
    public Transform slotHolder;
    
    private void Start()
    {
        slots = slotHolder.GetComponentsInChildren<Slot>();
        inventoryPanel.SetActive(activeInventory);
        Debug.Log("start");
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
}
