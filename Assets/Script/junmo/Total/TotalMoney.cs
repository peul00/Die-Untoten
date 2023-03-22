using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TotalMoney : MonoBehaviour
{
    private Text Totalmoney;
    public GameObject Fade;

    public void Start()
    {
        Totalmoney = GameObject.Find("Total").GetComponent<Text>();
        Totalmoney.text =
            "처음 돈: " + GameManager.instance.TotalMoney.ToString("N0") + "\n" + "\n"
            + "현재 돈: " + GameManager.instance.Money.ToString("N0") + "\n" + "\n" + "\n"
            + "----------------------------"
            + "수입: " + GameManager.instance.RealMoney.ToString("N0") + "\n" + "\n" + "\n"
            + "손님수, 추가 비용 등 더 상세하게 제작될 예정";
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
