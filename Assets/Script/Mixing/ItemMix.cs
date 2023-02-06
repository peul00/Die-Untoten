using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMix : MonoBehaviour
{
    private void OnMouseDown()
    {

    }

    private void OnMouseUp()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

    }
}
//1