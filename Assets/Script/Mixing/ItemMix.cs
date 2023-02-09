using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMix : MonoBehaviour
{
    private void OnMouseDown()
    {
        
    }

    private void OnMouseUp()
    {
       
    }
    public int Alcohol = 0;
    public int Spicy = 0;
    public int Sweet = 0;
    public int Bitter = 0;
    public int Sour = 0;
    public bool cool = false;
    public bool Orange = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {

    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                cool = true;
                Debug.Log("Ice: IsTrue");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Alcohol")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Alcohol += 1;
                Debug.Log("Alchohol: " + Alcohol);

            }
        }

        if (collision.gameObject.tag == "Spicy")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Spicy += 1;
                Debug.Log("Spicy: " + Spicy);
            }
        }

        if (collision.gameObject.tag == "Sweet")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Sweet += 1;
                Debug.Log("Sweet: " + Sweet);
            }
        }

        if (collision.gameObject.tag == "Bitter")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Bitter += 1;
                Debug.Log("Bitter: " + Bitter);
            }
        }

        if (collision.gameObject.tag == "Sour")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Sour += 1;
                Debug.Log("Sour: " + Sour);
            }
        }
    }

    [SerializeField] GameObject obj;
    [SerializeField] GameObject cocktail;
    [SerializeField] GameObject another;
    [SerializeField] GameObject fail;
    [SerializeField] GameObject ice;
    public void Makingcocktail()
    {
        if (Alcohol == 1 && Spicy == 0 && Sweet == 1 && Bitter == 0 && Sour == 0)
        {
            Destroy(obj);
            Instantiate(cocktail);
        }
        else if (Alcohol == 1 && Spicy == 1 && Sweet ==0 && Bitter == 1 && Sour ==0)
        {
            Destroy(obj);
            Instantiate(another);
        }
        else
        {
            Destroy(obj);
            Instantiate(fail);
        }
    }
    public void cold()
    {
        Instantiate(ice);
    }

    public void orange(bool isOn)
    {
        if (isOn)
        {
            Orange = true;
            Debug.Log("Orange true");
        }
        else
        {
            Orange = false;
            Debug.Log("Orange false");
        }
    }
}