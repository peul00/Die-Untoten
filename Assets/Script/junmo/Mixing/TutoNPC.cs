using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutoNPC : MonoBehaviour
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
        HP = 9999;
        CurrentHP = HP;
        Endu = 999;
        CurrentEndu = 999;
    }

    public void Start()
    {
        if(GameManager.instance.Day == 0)
        {
            Talk.text = "aaa";
        }
        if(GameManager.instance.Day == 1)
        {
            Talk.text = "bbb";
        }
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

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (Order == 1)
        {
            if (collision.gameObject.tag == "Seogyang")
            {
                SetTalk2();
                Order = Random.Range(1, 36);
                if (CurrentHP > OnDrag.Tip)
                {
                    CurrentHP -= OnDrag.Tip + (100 * Refill);
                    CurrentEndu += OnDrag.Tip / 10;
                    GameManager.instance.Money += Price + OnDrag.Tip + (100 * Refill);
                    Refill++;
                    Invoke("Wanted", 2.0f);
                }
                else if (CurrentHP <= OnDrag.Tip)
                {
                    OnDrag.Tip = (int)CurrentHP;
                    CurrentHP -= CurrentHP;
                    GameManager.instance.Money += Price + (int)CurrentHP;
                    Talk.text = "좋아요";
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
    }
}
