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
        GameObject.Find("Time").GetComponent<GameTime>().RunTime();
        GameObject.Find("GameManager").GetComponent<GameManager>().Totalmoney();
    }
    public void OnEnable()
    {
        Talk.text = "�ȳ��ϼ���";
        Order = Random.Range(1, 13);
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
    void In()
    {
        Talk.text = "�ݰ�����";
        gameObject.SetActive(true);
    }
    void Out()
    {
        gameObject.SetActive(false);
        Refill = 0;
    }
    public void CusOut()
    {
        Talk.text = "�����߾��";
        Invoke("Out", 1.0f);
    }
    void SetTalk()
    {
        Talk.text = "�̰� ���� ��Ų�� �ƴϱ���";
    }
    void SetTalk2()
    {
        Talk.text = "������ ���� �ɿ�?";
    }
    public void Wanted()
    {
        if (Order == 1)
        {
            Talk.text = "���� �ּ���";
        }
        else if (Order == 2)
        {
            Talk.text = "�ξ� ��� �ּ���";
        }
        else if (Order == 3)
        {
            Talk.text = "ļƮ�� �ּ���";
        }
        else if (Order == 4)
        {
            Talk.text = "�ƿ���� �ּ���";
        }
        else if (Order == 5)
        {
            Talk.text = "�ο��� �ּ���";
        }
        else if (Order == 6)
        {
            Talk.text = "���̷��� �ּ���";
        }
        else if (Order == 7)
        {
            Talk.text = "�긣��Ű�� �ּ���";
        }
        else if (Order == 8)
        {
            Talk.text = "K2C �ּ���";
        }
        else if (Order == 9)
        {
            Talk.text = "�ĸ��� �� �ּ���";
        }
        else if (Order == 10)
        {
            Talk.text = "�ϸ�� �ּ���";
        }
        else if (Order == 11)
        {
            Talk.text = "������ �ּ���";
        }
        else if (Order == 12)
        {
            Talk.text = "��ġ �ּ���";
        }
        else if (Order == 13)
        {
            Talk.text = "�ο����� �ּ���";
        }    
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if(Order == 1)
        {
            if (collision.gameObject.tag == "Seogyang")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip + (100 * Refill);
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Price + OnDrag.Tip + (100*Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Price + (int)CurrentHP;
                    Talk.text = "���ƿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        else if(Order == 2)
        {
            if (collision.gameObject.tag == "RoyalMoring")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 3)
        {
            if (collision.gameObject.tag == "KattCock")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 4)
        {
            if (collision.gameObject.tag == "AurumCock")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 5)
        {
            if (collision.gameObject.tag == "RoyalCock")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 6)
        {
            if (collision.gameObject.tag == "AirenCock")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 7)
        {
            if (collision.gameObject.tag == "BrgikyCock")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 8)
        {
            if (collision.gameObject.tag == "K2C")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        /*else if (Order == 9)
        {
            if (collision.gameObject.tag == "Souren")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        //else if (Order == 10)
        {
            if (collision.gameObject.tag == "BrgikyFloat")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        //else if (Order == 11)
        {
            if (collision.gameObject.tag == "BeeRoyal")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }*/
        else if (Order == 9)
        {
            if (collision.gameObject.tag == "FruiteBoobs")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        /*else if (Order == 13)
        {
            if (collision.gameObject.tag == "ThePool")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 14)
        {
            if (collision.gameObject.tag == "Black")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 15)
        {
            if (collision.gameObject.tag == "Sapphire")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 16)
        {
            if (collision.gameObject.tag == "Ruby")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 17)
        {
            if (collision.gameObject.tag == "Cantabile")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 18)
        {
            if (collision.gameObject.tag == "DeepKatt")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 19)
        {
            if (collision.gameObject.tag == "AlcohoRaid")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 20)
        {
            if (collision.gameObject.tag == "NoDog")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 21)
        {
            if (collision.gameObject.tag == "Freya")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 22)
        {
            if (collision.gameObject.tag == "ScorchingSun")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 23)
        {
            if (collision.gameObject.tag == "HeatWave")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 24)
        {
            if (collision.gameObject.tag == "EmeraldBeach")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 25)
        {
            if (collision.gameObject.tag == "Lost")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }*/
        else if (Order == 10)
        {
            if (collision.gameObject.tag == "Harmony")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 11)
        {
            if (collision.gameObject.tag == "HerbBuble")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 12)
        {
            if (collision.gameObject.tag == "Witch")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        /*else if (Order == 29)
        {
            if (collision.gameObject.tag == "Imoogi")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 30)
        {
            if (collision.gameObject.tag == "Peace")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 31)
        {
            if (collision.gameObject.tag == "Killer")
            {
                SetTalk2();
                Order = Random.Range(1, 12);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 32)
        {
            if (collision.gameObject.tag == "RuMilk")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }*/
        else if (Order == 13)
        {
            if (collision.gameObject.tag == "RoyalJelly")
            {
                SetTalk2();
                Order = Random.Range(1, 13);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 13);
                Invoke("Wanted", 2.0f);
            }
        }
        /*else if (Order == 34)
        {
            if (collision.gameObject.tag == "RoyalOrange")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }
        }
        else if (Order == 35)
        {
            if (collision.gameObject.tag == "KiKi")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip;
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Another + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Another + (int)CurrentHP;
                    Talk.text = "�����ؿ�";
                    Invoke("Out", 1.0f);
                    Invoke("In", 3.0f);
                }
            }
            else
            {
                SetTalk();
                Order = Random.Range(1, 36);
                Invoke("Wanted", 2.0f);
            }*/ 
    }
}
