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
    }
    public void OnEnable()
    {
        Talk.text = "안녕하세요";
        Order = Random.Range(1, 12);
        Invoke("Wanted", 2.0f);
        HP = Random.Range(200, 501);
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
            Out();
            Invoke("In", 2f);
        }
    }
    public void Wanted()
    {
        if (Order == 1)
        {
            Talk.text = "석양 주세요";
        }
        else if (Order == 2)
        {
            Talk.text = "로얄 모닝 주세요";
        }
        else if (Order == 3)
        {
            Talk.text = "캬트콕 주세요";
        }
        else if (Order == 4)
        {
            Talk.text = "아우룸콕 주세요";
        }
        else if (Order == 5)
        {
            Talk.text = "로열콕 주세요";
        }
        else if (Order == 6)
        {
            Talk.text = "아이렌콕 주세요";
        }
        else if (Order == 7)
        {
            Talk.text = "브르기키콕 주세요";
        }
        else if (Order == 8)
        {
            Talk.text = "K2C 주세요";
        }
        else if (Order == 9)
        {
            Talk.text = "샤워렌 주세요";
        }
        else if (Order == 10)
        {
            Talk.text = "브르기키 플룻 주세요";
        }
        else if (Order == 11)
        {
            Talk.text = "비 로열 주세요";
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(Order == 1)
        {
            if (collision.gameObject.tag == "a")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
                Invoke("Wanted", 2.0f);
            }
        }
        else if(Order == 2)
        {
            if (collision.gameObject.tag == "b")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 3)
        {
            if (collision.gameObject.tag == "c")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 4)
        {
            if (collision.gameObject.tag == "d")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 5)
        {
            if (collision.gameObject.tag == "e")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 6)
        {
            if (collision.gameObject.tag == "f")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 7)
        {
            if (collision.gameObject.tag == "g")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 8)
        {
            if (collision.gameObject.tag == "h")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 9)
        {
            if (collision.gameObject.tag == "i")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 10)
        {
            if (collision.gameObject.tag == "j")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 11)
        {
            if (collision.gameObject.tag == "k")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
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
                Order = Random.Range(1, 12);
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
    void SetTalk()
    {
        Talk.text = "이건 제가 시킨게 아니군요";
    }
    void SetTalk2()
    {
        Talk.text = "나쁘지 않은 걸요?";
    }
}
