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
    public int Day;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Update()
    {
        RealMoney = Money - TotalMoney;
    }

    public void DDay()
    {
        Day = Day +1;
    }

    public void Totalmoney()
    {
        TotalMoney = Money;
    }
}
