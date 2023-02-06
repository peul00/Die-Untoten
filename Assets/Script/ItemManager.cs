using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemNum;
    public GameObject item;
}


public class ItemManager : MonoBehaviour
{
    public List<Item> itemdata = new List<Item>();
}

//1
