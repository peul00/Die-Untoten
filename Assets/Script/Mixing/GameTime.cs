using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    private Text TimePoint;
    public GameObject Table;
    public GameObject Customer;

    public void Start()
    {
        TimePoint = GameObject.Find("Time").GetComponent<Text>();
        StartCoroutine("RTime");
    }
    public void Update()
    {
    }

    IEnumerator RTime()
    {
        int Timer = 1;
        while (true)
        {
            yield return new WaitForSeconds(60.0f);
            Timer++;
            TimePoint.text = (Timer.ToString() + "½Ã");
            if(Timer == 5)
            {
                Table.GetComponent<MoveTable>().Close();
                Customer.GetComponent<CusTomer>().CusOut();
            }
        }
    }
}
