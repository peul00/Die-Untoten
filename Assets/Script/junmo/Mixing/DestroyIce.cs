using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIce : MonoBehaviour
{
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Mix")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Destroy(gameObject);
            }
        }
    }
    public void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
        else
        {
            Destroy(gameObject, 1f);
        }
    }
}
