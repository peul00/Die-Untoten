using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CusTomer : MonoBehaviour
{
    public int FailPrice;
    public int Price;
    public int Another;

    private Text Talk;
    public void Start()
    {
        Talk = GameObject.Find("Talk").GetComponent<Text>();
    }
    void SetTalk()
    {
        Talk.text = "�̰� ���� ��Ų�� �ƴϱ���";
    }
    void SetTalk2()
    {
        Talk.text = "������ ���� �ɿ�?";
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Fail")
        {
            SetTalk();
        }

        if (collision.gameObject.tag == "Cock")
        {
            ItemDatabase.instance.Money += Price;
            SetTalk2();
        }

        if (collision.gameObject.tag == "Another")
        {
            ItemDatabase.instance.Money += Another;
            SetTalk2();
        }
    }
}
