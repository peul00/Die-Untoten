using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDrag : MonoBehaviour
{
    public int Price;
    private void OnMouseDrag()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }
    public GameObject location1;
    public GameObject location2;
    public void OnMouseUp()
    {
        if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
        {
            transform.position = location1.transform.position;

        }
        else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
        {
            if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
            {
                transform.position = location2.transform.position;
            }
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Costomer")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Destroy(gameObject);
                ItemDatabase.instance.Money += Price;
            }
        }
    }
}
