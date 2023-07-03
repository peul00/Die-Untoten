using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject menuSet;
    public GameObject menuSet2;
    public GameObject Settingset;
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
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuSet.activeSelf)
            {
                menuSet.SetActive(false);
            }
            else
            {
                menuSet.SetActive(true);
            }
        }
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuSet2.activeSelf)
            {
                menuSet2.SetActive(false);
            }
            else
            {
                menuSet2.SetActive(true);
            }
        }
        if (Input.GetButtonDown("Cancel"))
        {
            if (Settingset.activeSelf)
                Settingset.SetActive(false);
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
    public void OnExitBtn()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
