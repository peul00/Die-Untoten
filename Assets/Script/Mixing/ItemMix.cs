using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ItemManager;

public class ItemMix : MonoBehaviour
{

    private void OnMouseDown()
    {
        
    }

    private void OnMouseUp()
    {
       
    }
    int Alcohol = 0;
    int ab = 0;
    int bb = 0;

    public void OnTriggerEnter2D(Collider2D collision)
    {

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "card")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Alcohol += 1;
                ab += 1;
                Debug.Log("Alchohol: " + Alcohol);
                Debug.Log("bb: " + bb);
                Debug.Log("ab: " + ab);
            }
        }

        if (collision.gameObject.tag == "card1")
        {
            if (Input.GetMouseButton(0) == false)
            {
                Alcohol += 1;
                bb += 1;
                Debug.Log("Alchohol: " + Alcohol);
                Debug.Log("bb: " + bb);
                Debug.Log("ab: " + ab);
            }
        }
    }
}