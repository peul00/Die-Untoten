using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMix : MonoBehaviour
{
    public GameObject Firstgauge;
    public GameObject liqueur;
    private void OnMouseDown()
    {
        
    }

    private void OnMouseUp()
    {
       
    }
    public static int Alcohol;
    public static int Spicy;
    public static int Sweet;
    public static int Bitter;
    public static int Sour;
    public bool cool = false;
    public bool Orange = false;
    public bool Liqueur = false;
    public int Plus;

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

        if (collision.gameObject.tag == "Liqueur")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Liqueur = true;
                liqueur.gameObject.SetActive(true);
                Debug.Log("Liqueur: true");
            }
        }

        if (0 < Sweet || 0 < Spicy || 0 < Bitter || 0 < Sour || 0 < Alcohol)
        {
            Plus = Alcohol + Spicy + Sweet + Bitter + Sour;
            Debug.Log("Total: " + Plus);
            Firstgauge.gameObject.SetActive(true);
        }
    }

    [SerializeField] GameObject obj;
    [SerializeField] GameObject cocktail;
    [SerializeField] GameObject another;
    [SerializeField] GameObject fail;
    [SerializeField] GameObject ice;
    public void Makingcocktail()
    {
        if (Alcohol == 1 && Spicy == 0 && Sweet == 1 && Bitter == 0 && Sour == 0 && Liqueur && Orange)
        {
            Destroy(obj);
            Instantiate(cocktail);
        }
        else if (Alcohol == 1 && Spicy == 1 && Sweet ==0 && Bitter == 1 && Sour ==0 && cool)
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