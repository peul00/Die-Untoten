using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDrag : MonoBehaviour
{
    public string Tag;
    int Rank = Drag.MaxRank;
    int Plus = ItemMix.AlcoPlus;
    public static int Average;
    public static int Tip;
    public void Start()
    {
        Average = Rank / Plus;
        Debug.Log("Level: " + Average);
    }

    public void Update()
    {
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
            if (Average <= 1)
            {
                Tip = Random.Range(1, 11);
            }
            else if (Average <= 2)
            {
                Tip = Random.Range(11, 51);
            }
            else if (Average <= 3)
            {
                Tip = Random.Range(51, 101);
            }
            else
            {
                Tip = Random.Range(101, 201);
            }
            Debug.Log("Tip = " + Tip);
        }
        else if(collision.gameObject.tag == "Mix")
        {
            gameObject.tag = Tag;
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Costomer")
        {
            if (Input.GetMouseButton(0) == true)
            {
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.tag == "Mix")
        {
            if (Input.GetMouseButton(0) == true)
            {
                Destroy(gameObject);
            }
        }
    }
}
