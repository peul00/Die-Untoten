using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    bool activeInventory = false;

    private void Start()
    {
        inventoryPanel.SetActive(activeInventory);
        Debug.Log("start");
    }

    void FixedUpdate()
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
