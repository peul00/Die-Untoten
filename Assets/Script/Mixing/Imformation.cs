using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Imformation : MonoBehaviour
{
    private Text Information;
    public GameObject Recipt;
    public GameObject recipt;
    void Update()
    {
        Information = recipt.GetComponent<Text>();
    }

    public void Return()
    {
        Recipt.gameObject.SetActive(true);
        recipt.gameObject.SetActive(false);
    }
    public  void aa()
    {
        Recipt. gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "석양" + "\n" + "\n" + "아이렌3 아우룸1 코코넛주스1 크랜베리 시럽" + "\n" + "build";
    }
    public void bb()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "로얄 모닝" + "\n" + "\n" + "브르기키2 로열1 토마토주스3 소금" + "\n" + "build";
    }
    public void cc()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "캬트콕" + "\n" + "\n" + "캬트2 소다4 얼음" + "\n" + "build";
    }
    public void dd()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "아우룸콕" + "\n" + "\n" + "아우룸2 소다4 얼음" + "\n" + "build";
    }
    public void ee()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "로열콕" + "\n" + "\n" + "로열2 소다4 얼음" + "\n" + "build";
    }
    public void ff()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "아이렌콕" + "\n" + "\n" + "아이렌2 소다4 얼음" + "\n" + "build";
    }
    public void gg()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "브르기키콕" + "\n" + "\n" + "브르기키2 소다4 얼음" + "\n" + "build";
    }
    public void hh()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "K2C" + "\n" + "\n" + "로열5 브르기키4" + "\n" + "build";
    }
    public void ii()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "샤워렌" + "\n" + "\n" + "아이렌2 로열4 오렌지 시럽 얼음" + "\n" + "build";
    }
    public void jj()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "브르기키 플룻" + "\n" + "\n" + "캬트1 브르기키3 소다1 설탕 얼음" + "\n" + "build";
    }
    public void kk()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "비 로열" + "\n" + "\n" + "브리기키2 아우룸1 로열2 설탕 얼음" + "\n" + "build";
    }
}
