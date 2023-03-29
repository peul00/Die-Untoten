using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTime : MonoBehaviour
{
    private Text TimePoint;
    public GameObject Table;
    public GameObject Customer;
    public GameObject Fade;
    [SerializeField]
    [Range(0.01f, 60f)]
    private float DeTime;

    public void Start()
    {
        TimePoint = GameObject.Find("Time").GetComponent<Text>();
    }
    public void Update()
    {
    }

    public void RunTime()
    {
        StartCoroutine("RTime");
    }

    IEnumerator RTime()
    {
        int Timer = 1;
            while (true)
            {
                yield return new WaitForSeconds(DeTime);
                Timer++;
                TimePoint.text = (Timer.ToString() + "½Ã");
                if (Timer == 5)
                {
                    Fade.SetActive(true);
                    Table.GetComponent<MoveTable>().Close();
                    Customer.GetComponent<CusTomer>().CusOut();
                    Fade.GetComponent<FadeOut>().Out();
                    Invoke("NextDay", 3f);
                }
            }
    }

    void NextDay()
    {
        SceneManager.LoadScene("Total");
    }

    public void Custom()
    {
        Customer.SetActive(true);
    }
}
