using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDrag : MonoBehaviour
{
    public string Tag;
    int Rank = Drag.MaxRank;
    int Plus = ItemMix.Plus;
    public static int Average;

    public void Update()
    {
        Average = Rank / Plus;
        Debug.Log(Average);
    }

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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Costomer")
        {
            gameObject.tag = Tag;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Costomer")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Destroy(gameObject);
            }
        }
    }
}
