using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Base,
    Cocktail,
    Syrup,
    Fruit,
    Other
}


[System.Serializable]
public class Item 
{
    public ItemType ItemType;
    public string itmeName;
    public int ItemCost;
    public Sprite itemImage;
    
    public bool Use()
    {
        return false;
    }
}
