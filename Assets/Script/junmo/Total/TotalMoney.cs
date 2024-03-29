using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalMoney : MonoBehaviour
{
    private Text Totalmoney;
    public GameObject Fade;
    List<int> Sell = GameManager.instance.Sell;
    public List<int> Sell2 = new List<int>();
    int i;

    public void Start()
    {
        Totalmoney = GameObject.Find("Total").GetComponent<Text>();
        for (i = 1; i < Sell.Count; i++)
        {
            Sell2.Add(Sell[i]);
        }
        Totalmoney.text =
            GameManager.instance.TotalMoney + "\n"
            + string.Join("\n", Sell2) + "\n"
            + "\n"
            + GameManager.instance.RealMoney + "\n"
            + GameManager.instance.Money + "\n";
    }
    public void Rest()
    {
        Fade.SetActive(true);
        Invoke("Chan", 3f);
    }
    public void Chan()
    {
        SceneManager.LoadScene("Night");
    }
}
