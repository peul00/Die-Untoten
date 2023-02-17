using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldItem : MonoBehaviour
{
    // Start is called before the first frame update
    public Item item;
    public SpriteRenderer image;

    public void SetItem(Item _item)
    {
        item.itmeName = _item.itmeName;
        item.itemImage = _item.itemImage;
        item.ItemType = _item.ItemType;

        image.sprite = item.itemImage;
    }
    public Item GetItem()
    {
        return item;
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
