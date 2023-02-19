using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gauage : MonoBehaviour
{
    public GameObject nextgauge;
    public int Num;

    private void Update()
    {
        int Count = ItemMix.Plus;
        if (Num + 1 == Count)
        {
            nextgauge.gameObject.SetActive(true);
        }        
    }

    public void ReSet()
    {
        nextgauge.gameObject.SetActive(false);
    }
}
