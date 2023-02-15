using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMix : MonoBehaviour
{
    public GameObject Firstgauge;
    public GameObject liqueur;
    public GameObject IcePoint;
    public GameObject ice;
    public static int Alcohol;
    public static int Spicy;
    public static int Sweet;
    public static int Bitter;
    public static int Sour;
    public bool cool = false;
    public bool Orange = false;
    public bool Liqueur = false;
    public int Plus;

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

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ice")
        {
            if (Input.GetMouseButton(0) == false)
            {
                cool = true;
                Debug.Log("Ice: IsTrue");
                IcePoint.gameObject.SetActive(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Alcohol")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    Alcohol += 1;
                Debug.Log("Alchohol: " + Alcohol);
            }
        }

        if (collision.gameObject.tag == "Spicy")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    Spicy += 1;
                Debug.Log("Spicy: " + Spicy);
            }
        }

        if (collision.gameObject.tag == "Sweet")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    Sweet += 1;
                Debug.Log("Sweet: " + Sweet);
            }
        }

        if (collision.gameObject.tag == "Bitter")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if (Plus != 10)
                    Bitter += 1;
                Debug.Log("Bitter: " + Bitter);
            }
        }

        if (collision.gameObject.tag == "Sour")
        {
            if (Input.GetMouseButton(0) == false)
            {
                if(Plus != 10)
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

    [SerializeField] GameObject Seogyang;
    [SerializeField] GameObject RoyalMorning;
    [SerializeField] GameObject KattCock;
    [SerializeField] GameObject AurumCock;
    [SerializeField] GameObject RoyalCock;
    [SerializeField] GameObject AirenCock;
    [SerializeField] GameObject BrgikyCock;
    [SerializeField] GameObject K2C;
    [SerializeField] GameObject Souren;
    [SerializeField] GameObject BrgikyFloat;
    [SerializeField] GameObject BeeRoyal;
    [SerializeField] GameObject fail;
    public Transform location1;
    public Transform location2;
    public void Makingcocktail()
    {
        if (Alcohol == 0 && Spicy == 0 && Sweet == 3 && Bitter == 1 && Sour == 0 && Liqueur)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Seogyang, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Seogyang, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 0 && Spicy == 2 && Sweet ==0 && Bitter == 0 && Sour ==1 && Liqueur)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(RoyalMorning, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(RoyalMorning, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 2 && Spicy == 0 && Sweet == 0 && Bitter == 0 && Sour == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(KattCock, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(KattCock, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 1 && Spicy == 1 && Sweet == 0 && Bitter == 1 && Sour == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(AurumCock, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(AurumCock, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 1 && Spicy == 1 && Sweet == 0 && Bitter == 1 && Sour == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(RoyalCock, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(RoyalCock, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 1 && Spicy == 1 && Sweet == 0 && Bitter == 1 && Sour == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(AirenCock, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(AirenCock, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 1 && Spicy == 1 && Sweet == 0 && Bitter == 1 && Sour == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(BrgikyCock, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(BrgikyCock, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 1 && Spicy == 1 && Sweet == 0 && Bitter == 1 && Sour == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(K2C, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(K2C, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 1 && Spicy == 1 && Sweet == 0 && Bitter == 1 && Sour == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(Souren, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(Souren, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 1 && Spicy == 1 && Sweet == 0 && Bitter == 1 && Sour == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(BrgikyFloat, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(BrgikyFloat, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else if (Alcohol == 1 && Spicy == 1 && Sweet == 0 && Bitter == 1 && Sour == 0 && cool)
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(BeeRoyal, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(BeeRoyal, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
        else
        {
            if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == false)
            {
                Instantiate(fail, location1.position, location1.rotation);

            }
            else if (GameObject.Find("Location1").GetComponent<Scanner>().scanner == true)
            {
                if (GameObject.Find("Location2").GetComponent<Scanner>().scanner == false)
                {
                    Instantiate(fail, location2.position, location2.rotation);
                }
                else
                    Debug.Log("no");
            }
        }
    }
    public void Rerecipt()
    {
        Firstgauge.gameObject.SetActive(false);
        liqueur.gameObject.SetActive(false);
        IcePoint.gameObject.SetActive(false);
        GameObject.Find("Orange").GetComponent<Toggle>().isOn = false;
        Alcohol = 0;
        Spicy = 0;
        Sweet = 0;
        Bitter = 0;
        Sour = 0;
        Liqueur = false;
        cool = false;
        Orange = false;
    }
}