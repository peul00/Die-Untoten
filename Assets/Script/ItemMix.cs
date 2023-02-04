using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMix : MonoBehaviour
{
    Item item;

    public void Init()
    {
        item = ;
    }

    private void OnMouseDown()
    {
    }

    private void OnMouseUp()
    {
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(item.itemNum == collision.GetComponent<ItemManager>().itemNum)
        {
            if(item != null)
            {
                Destroy(collision.gameObject);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }
}
