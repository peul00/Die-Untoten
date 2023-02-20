using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CusTomer : MonoBehaviour
{
    public int Order;
    public int Price;
    public int Another;
    public float HP;
    public float CurrentHP;
    public float Endu;
    public float CurrentEndu;
    public Slider Hpbar;
    public Slider Endubar;
    public int Refill;

    private Text Talk;

    public void Awake()
    {
        Talk = GameObject.Find("Talk").GetComponent<Text>();
        Talk.text = "시작해 볼까요?";
    }
    public void OnEnable()
    {
        Order = Random.Range(1, 3);
        Invoke("Wanted", 2.0f);
        HP = Random.Range(500, 1001);
        CurrentHP = HP;
        Endu = Random.Range(60, 121);
        CurrentEndu = Random.Range(30, Endu);
    }
    public void Update()
    {
        Hpbar.value = CurrentHP / HP;
        Endubar.value = CurrentEndu / Endu;
        CurrentEndu -= Time.deltaTime;
        if (CurrentEndu <= 0)
        {
            gameObject.SetActive(false);
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
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(Order == 1)
        {
            if (collision.gameObject.tag == "Cock")
            {
                SetTalk2();
                Order = Random.Range(1, 3);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip + (100 * Refill);
                    CurrentEndu += OnDrag.Tip / 10;
                    ItemDatabase.instance.Money += Price + OnDrag.Tip + (100*Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    ItemDatabase.instance.Money += Price + (int)CurrentHP;
                    Talk.text = "좋아요";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
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
                SetTalk2();
                Order = Random.Range(1, 3);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    ItemDatabase.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    ItemDatabase.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "감사해요";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 3);
                Invoke("Wanted", 2.0f);
            }
        }
    }
    void In()
    {
        Talk.text = "반가워요";
        gameObject.SetActive(true);
    }
    void Out()
    {
        gameObject.SetActive(false);
        Refill = 0;
    }
    public void CusOut()
    {
        Talk.text = "수고했어요";
        Invoke("Out", 1.0f);
    }
    void SetOrder()
    {
        Talk.text = "파란색 주세요";
    }

    void SetOrder2()
    {
        Talk.text = "주황색 주세요";
    }
    void SetTalk()
    {
        Talk.text = "이건 제가 시킨게 아니군요";
    }
    void SetTalk2()
    {
        Talk.text = "나쁘지 않은 걸요?";
    }
}
