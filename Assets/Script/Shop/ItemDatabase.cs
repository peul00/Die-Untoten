using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.UI;

public class ItemDatabase : MonoBehaviour
{
    // Start is called before the first frame update
    public static ItemDatabase instance;

    public int Money = 0;
    private Text MoneyPoint; // µ∑ ∫∏¿Ã∞‘«‘
    private void Awake()
    {
        instance = this;
        
    }

    public List<Item> itemDB = new List<Item>();
    public GameObject fieldItemPrefab;
    public Vector3[] pos;

    public void Start()
    {
        Money = 10000;
        string str_int = Money.ToString();
        MoneyPoint = GameObject.Find("Money").GetComponent<Text>();
    }

    public void Update()
    {
        SetMoneyText();
    }

    void SetMoneyText()
    {
        MoneyPoint.text = Money.ToString("c"); //N0 \«•Ω√ ªÁ∂Û¡¸
    }

    public GameObject Custom; // º’¥‘πﬁ±‚
    public void Cus()
    {
        Custom.gameObject.SetActive(true);
    }
}
