using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyPoint : MonoBehaviour
{
    private Text Moneypoint; // µ∑ ∫∏¿Ã∞‘«‘

    public void Start()
    {
        string str_int = ItemDatabase.instance.Money.ToString();
        Moneypoint = GameObject.Find("Money").GetComponent<Text>();
    }

    public void Update()
    {
        SetMoneyText();
    }

    void SetMoneyText()
    {
        Moneypoint.text = ItemDatabase.instance.Money.ToString("c"); //N0 \«•Ω√ ªÁ∂Û¡¸
    }

    public GameObject Custom; // º’¥‘πﬁ±‚
    public void Cus()
    {
        Custom.gameObject.SetActive(true);
    }
}
