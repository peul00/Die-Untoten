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
        shop.SetActive(false);
        openShop.onClick.AddListener(ActiveShop);
        closeShop.onClick.AddListener(DeActivateShop);
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
        if (Input.GetKeyDown(KeyCode.I) && isShopActive) 
        {
            Debug.Log("2");
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);
        }
        /*if (Input.GetMouseButtonUp(0))
        {
            RayShop();
        }*/
    }
    


    public void AddSlot()
    {
        inven.SlotCnt++;
    }

    public GameObject shop;
    public Button openShop;
    public Button closeShop;
    public bool isShopActive;


    /*public void RayShop()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -10;
        if(!UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(-1))
        RaycastHit2D hit2D = Physics2D.Raycast(mousePos, transform.forward, 30);
        if (hit2D.collider != null)
        {
            if (hit2D.collider.CompareTag("Shop"))
            {
                if (!isShopActive)
                {
                    ActiveShopst(true);
                }
                
            }
        }
    }*/



    public void ActiveShopst(bool isOpen)
    {
        if (!activeInventory)
        {
            isShopActive = isOpen;
            shop.SetActive(isOpen);
            inventoryPanel.SetActive(isOpen);
        }
    }

    public void ActiveShop()
    {
        ActiveShopst(true);
    }
    public void DeActivateShop()
    {
        ActiveShopst(false);
    }
}
