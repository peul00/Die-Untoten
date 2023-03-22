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
            "ó�� ��: " + GameManager.instance.TotalMoney.ToString("N0") + "\n" + "\n"
            + "���� ��: " + GameManager.instance.Money.ToString("N0") + "\n" + "\n" + "\n"
            + "----------------------------"
            + "����: " + GameManager.instance.RealMoney.ToString("N0") + "\n" + "\n" + "\n"
            + "�մԼ�, �߰� ��� �� �� ���ϰ� ���۵� ����";
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
