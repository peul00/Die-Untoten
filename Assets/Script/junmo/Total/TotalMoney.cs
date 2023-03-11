using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalMoney : MonoBehaviour
{
    private Text Totalmoney;

    public void Start()
    {
        Totalmoney = GameObject.Find("Total").GetComponent<Text>();
        Totalmoney.text = "���� ��" + ItemDatabase.instance.Money.ToString("N0");
    }
    public void Rest()
    {
        SceneManager.LoadScene("Night");
    }
}
