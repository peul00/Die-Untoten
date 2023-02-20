using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
//using UnityEngine.UIElements;

public class InventoryUI : MonoBehaviour
{
    Inventory inven;

    
    public GameObject inventoryPanel;
    bool activeInventory = false;

    public Slot[] slots;
    public Transform slotHolder;
    public ShopSlot[] shopSlots;
    public Transform shopHolder;

    public void Awake()
    {
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        shopSlots = shopHolder.GetComponentsInChildren<ShopSlot>();
        inven.onSlotCountChange += SlotChange;
        inven.onChangeItem += RedrawSlotUI;
    }

    public void Start()
    {
        shop.gameObject.SetActive(false);
        inventoryPanel.SetActive(activeInventory);
        RedrawSlotUI();
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
        //Debug.Log("update");
        if (Input.GetKeyDown(KeyCode.I))//&& isShopActive) 
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
    void RedrawSlotUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            //slots[i].RemoveSlot();
        }
        for (int i = 0; i < inven.items.Count; i++)
        {
            slots[i].item = inven.items[i];
            slots[i].UpdateSlotUI();
        }
    }

    public GameObject shop;
    public Button openShop;
    public Button closeShop;
    public bool isShopActive;

    public ShopData shopData;


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
                    shopData hit2D.collider.GetComponent<ShopData>();
                    for(int i = 0;i <shopData.stocks.Count;i++)
                    {
                        
                    }
    
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
            for(int i = 0; i < slots.Length; i++)
            {
                slots[i].isShopMode = isOpen;
            }
        }
    }

    public void ActiveShop()
    {
        ActiveShopst(true);
        shopData = GetComponent<ShopData>();
        for (int i = 0; i < shopData.stocks.Count; i++)
        {
            shopSlots[i].item = shopData.stocks[i];
            shopSlots[i].UpdateSlotUI();
        }
    }
    public void DeActivateShop()
    {
        ActiveShopst(false);
    }

    public void SellBtn()
    {
        for(int i = slots.Length; i> 0; i--)
        {
            slots[i-1].SellItem();
        }
    }


    //»óÁ¡ ²°´Ù Ä×´Ù Ãß°¡ÇÔ
    public void ShopOpen()
    {
        shop.gameObject.SetActive(true);
    }

    public void ShopClose()
    {
        shop.gameObject.SetActive(false);
    }
}
