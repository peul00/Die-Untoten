using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDrag : MonoBehaviour
{

    private void OnMouseDrag()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    private void OnMouseUp()
    {
        //transform.position = new Vector2(0, -2);
    }
    public void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Serving")
        {
            transform.position = new Vector2(0, 0);
        }
        else
        {
            transform.position = new Vector2(0, -2);
        }

    }
}
