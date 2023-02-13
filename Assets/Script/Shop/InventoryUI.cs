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

    private void Start()
    {
        inventoryPanel.SetActive(activeInventory);
        Debug.Log("start");
    }

    void Update()
    {
        Debug.Log("update");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("2");
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);
        }
    } 
}
