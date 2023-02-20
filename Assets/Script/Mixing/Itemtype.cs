using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemtype : MonoBehaviour
{
    public Item ItemImage;
    public SpriteRenderer Itemimage;
    public int Goods;

    public void OnEnable()
    {
        ItemImage = ItemDatabase.instance.itemDB[Goods];
        Itemimage.sprite = ItemImage.itemImage;
    }
}
