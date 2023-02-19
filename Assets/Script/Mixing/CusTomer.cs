using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CusTomer : MonoBehaviour
{
    int Average = OnDrag.Average;
    public int Order;
    public int Tip;
    public int FailPrice;
    public int Price;
    public int Another;

    private Text Talk;

    public void Awake()
    {
        Talk = GameObject.Find("Talk").GetComponent<Text>();
    }
    public void OnEnable()
    {
        Talk.text = "������ �����?";
        Order = Random.Range(1, 3);
        Invoke("Wanted", 2.0f);
    }
    public void Update()
    {
        if(Average <= 1)
        {
            Tip = Random.Range(1, 10);
        }
        else if(Average <= 2)
        {
            Tip = Random.Range(11, 50);
        }
        else if (Average <= 3)
        {
            Tip = Random.Range(51, 100);
        }
        else
        {
            Tip = Random.Range(101, 200);
        }
    }
    public void Wanted()
    {
        if (Order == 1)
        {
            SetOrder();
        }
        else if (Order == 2)
        {
            SetOrder2();
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(Order == 1)
        {
            if (collision.gameObject.tag == "Cock")
            {
                ItemDatabase.instance.Money += Price + Tip;
                SetTalk2();
                Order = Random.Range(1, 3);
                Invoke("Wanted", 2.0f);
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 3);
                Invoke("Wanted", 2.0f);
            }
        }
        else if(Order == 2)
        {
            if (collision.gameObject.tag == "Another")
            {
                ItemDatabase.instance.Money += Another + Tip;
                SetTalk2();
                Order = Random.Range(1, 3);
                Invoke("Wanted", 2.0f);
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 3);
                Invoke("Wanted", 2.0f);
            }
        }
    }
    void Out()
    {
        gameObject.SetActive(false);
    }
    public void CusOut()
    {
        Talk.text = "�����߾��";
        Invoke("Out", 1.0f);
    }
    void SetOrder()
    {
        Talk.text = "�Ķ��� �ּ���";
    }

    void SetOrder2()
    {
        Talk.text = "��Ȳ�� �ּ���";
    }
    void SetTalk()
    {
        Talk.text = "�̰� ���� ��Ų�� �ƴϱ���";
    }
    void SetTalk2()
    {
        Talk.text = "������ ���� �ɿ�?";
    }
}
