using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject obj;
    public int TotalMoney;
    public int Money;
    public int RealMoney;
    public int TMoney;
    public int Day;
    public List<int> Sell = new List<int>();

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
        TMoney = RealMoney;
    }

    public void Update()
    {
        RealMoney = Money - TotalMoney;
        if(RealMoney != TMoney)
        {
            Sell.Add(RealMoney - TMoney);
            TMoney = RealMoney;
        }
    }

    public void DDay()
    {
        Day = Day +1;
    }

    public void Totalmoney()
    {
        TotalMoney = Money;
        Sell.RemoveRange(0, Sell.Count);
;   }
}
