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
        Information.text = "����" + "\n" + "\n" + "���̷�3 �ƿ��1 ���ڳ��ֽ�1 ũ������ �÷�" + "\n" + "build";
    }
    public void bb()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�ξ� ���" + "\n" + "\n" + "�긣��Ű2 �ο�1 �丶���ֽ�3 �ұ�" + "\n" + "build";
    }
    public void cc()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "ļƮ��" + "\n" + "\n" + "ļƮ2 �Ҵ�4 ����" + "\n" + "build";
    }
    public void dd()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�ƿ����" + "\n" + "\n" + "�ƿ��2 �Ҵ�4 ����" + "\n" + "build";
    }
    public void ee()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�ο���" + "\n" + "\n" + "�ο�2 �Ҵ�4 ����" + "\n" + "build";
    }
    public void ff()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "���̷���" + "\n" + "\n" + "���̷�2 �Ҵ�4 ����" + "\n" + "build";
    }
    public void gg()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�긣��Ű��" + "\n" + "\n" + "�긣��Ű2 �Ҵ�4 ����" + "\n" + "build";
    }
    public void hh()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "K2C" + "\n" + "\n" + "�ο�5 �긣��Ű4" + "\n" + "build";
    }
    public void ii()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "������" + "\n" + "\n" + "���̷�2 �ο�4 ������ �÷� ����" + "\n" + "build";
    }
    public void jj()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�긣��Ű �÷�" + "\n" + "\n" + "ļƮ1 �긣��Ű3 �Ҵ�1 ���� ����" + "\n" + "build";
    }
    public void kk()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� �ο�" + "\n" + "\n" + "�긮��Ű2 �ƿ��1 �ο�2 ���� ����" + "\n" + "build";
    }
}
