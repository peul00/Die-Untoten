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
    public  void Seogyang()
    {
        Recipt. gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "����" + "\n" + "\n" + "���̷�3 �ƿ��1 ���ڳ��ֽ�1 ũ������ �÷�" + "\n" + "build";
    }
    public void RoyalMorning()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�ξ� ���" + "\n" + "\n" + "�긣��Ű2 �ο�1 �丶���ֽ�3 �ұ�" + "\n" + "build";
    }
    public void KattCock()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "ļƮ ��" + "\n" + "\n" + "ļƮ2 �Ҵ�4 ����" + "\n" + "build";
    }
    public void AurumCock()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�ƿ�� ��" + "\n" + "\n" + "�ƿ��2 �Ҵ�4 ����" + "\n" + "build";
    }
    public void RoyalCock()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�ο� ��" + "\n" + "\n" + "�ο�2 �Ҵ�4 ����" + "\n" + "build";
    }
    public void AirenCock()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "���̷� ��" + "\n" + "\n" + "���̷�2 �Ҵ�4 ����" + "\n" + "build";
    }
    public void BrgikyCock()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�긣��Ű ��" + "\n" + "\n" + "�긣��Ű2 �Ҵ�4 ����" + "\n" + "build";
    }
    public void K2C()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "K2C" + "\n" + "\n" + "�ο�5 �긣��Ű4" + "\n" + "build";
    }
    public void Souren()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "������" + "\n" + "\n" + "���̷�2 �ο�4 ������ �÷� ����" + "\n" + "build";
    }
    public void BrgikyFloat()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�긣��Ű �÷�" + "\n" + "\n" + "ļƮ1 �긣��Ű3 �Ҵ�1 ���� ����" + "\n" + "build";
    }
    public void BeeRoyal()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� �ο�" + "\n" + "\n" + "�긮��Ű2 �ƿ��1 �ο�2 ���� ����" + "\n" + "build";
    }
    public void FruitBoobs()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�ĸ��� ��" + "\n" + "\n" + "���̷�3 �ο�1 �Ҵ�3 ����" + "\n" + "blending";
    }
    public void ThePool()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� Ǯ" + "\n" + "\n" + "�긮��Ű2 ���̷�1 �ƿ��5 �����ֽ�1 �� ����" + "\n" + "blending" + "\n" + "�ұ�" + "\n" + "build";
    }
    public void Black()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "��" + "\n" + "\n" + "ļƮ2 �ƿ��5 �� ����" + "\n" + "blending" + "\n" + "�ұ�" + "\n" + "build";
    }
    public void Sapphire()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�����̾� ���Ʈ" + "\n" + "\n" + "ļƮ3 �긣��Ű1 �ξ�2 �Ҵ�2 ũ������ �÷� ����" + "\n" + "blending";
    }
    public void Ruby()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "��� ���Ʈ" + "\n" + "\n" + "ļƮ3 �긣��Ű1 ���̷�2 �Ҵ�2 ũ������ �÷� ����" + "\n" + "blending";
    }
    public void Cantabile()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "ĭŸ����" + "\n" + "\n" + "���̷�2 �ƿ��1 �ο�1 ü���ֽ� ����" + "\n" + "blending";
    }
    public void DeepKatt()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� ļƮ" + "\n" + "\n" + "ļƮ7 ����" + "\n" + "blending";
    }
    public void AlcohoRaid()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "���ݷ��̵�" + "\n" + "\n" + "ļƮ3 ���̷�1 �ο�1 �����ֽ�1 ������ �÷�" + "\n" + "Shake" + "\n" + "�ұ�" + "\n" + "build";
    }
    public void NoDog()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� ����" + "\n" + "\n" + "ļƮ1 ���̷�4 �ο�1 ���ݸ� �÷�" + "\n" + "Shake" + "\n" + "����" + "\n" + "build";
    }
    public void Freya()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�����̾�" + "\n" + "\n" + "ļƮ2 �긣��Ű1 ���̷�1 �ƿ��1 �ο�1 ����ֽ�2 ��" + "\n" + "Shake" + "\n" + "����" + "\n" + "build";
    }
    public void ScorchingSun()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� �ο�" + "\n" + "\n" + "ļƮ3 �긣��Ű2 �Ҵ�1" + "\n" + "Shake" + "\n" + "�ұ�" + "\n" + "build";
    }
    public void HeatWave()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� �ο�" + "\n" + "\n" + "ļƮ3 �긣��Ű4 �Ҵ�1" + "\n" + "Shake" + "\n" + "�ұ�" + "\n" + "build";
    }
    public void EmeraldBeach()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� �ο�" + "\n" + "\n" + "���̷�3 �ο�3 �����ֽ�1 ���ڳ��ֽ�1 ��н÷�" + "\n" + "Shake";
    }
    public void Lost()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� �ο�" + "\n" + "\n" + "�긣��Ű3 ���̷�1 �ƿ��4 ����" + "\n" + "Shake";
    }
    public void Harmony()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� �ο�" + "\n" + "\n" + "ļƮ3 ���̷�2 �ƿ��1 ü���ֽ�" + "\n" + "Shake";
    }
    public void HerbBuble()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� �ο�" + "\n" + "\n" + "ļƮ1 ���̷�1 �ƿ��5" + "\n" + "Shake";
    }
    public void Witch()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "��ġ" + "\n" + "\n" + "���̷�3 �ƿ��1 �ο�2 ����ֽ�1" + "\n" + "Stirring";
    }
    public void Imoogi()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�̹���" + "\n" + "\n" + "ļƮ1 ���̷�3 �ƿ��2 �� ����" + "\n" + "Stirring";
    }
    public void Peace()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�ǽ�" + "\n" + "\n" + "ļƮ1 �ƿ��1 �ο�1 ���̷�1 �긣��Ű1" + "\n" + "Stirring";
    }
    public void Killer()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "ų��" + "\n" + "\n" + "ļƮ2 ���̷�1 �ο�1 ���ڳ��ֽ�1" + "\n" + "Stirring";
    }
    public void RuMilk()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�� ��ũ" + "\n" + "\n" + "ļƮ4 ���̷�3 �Ҵ�1" + "\n" + "Stirring";
    }
    public void RoyalJelly()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�ο� ����" + "\n" + "\n" + "���̷�2 �����ֽ�1 �� ����" + "\n" + "Stirring";
    }
    public void RoyalOrange()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "�ο� ������" + "\n" + "\n" + "ļƮ1 ���̷�2 �ο�4 ������ �÷� ����" + "\n" + "Stirring";
    }
    public void KiKi()
    {
        Recipt.gameObject.SetActive(false);
        recipt.gameObject.SetActive(true);
        Information.text = "ŰŰ" + "\n" + "\n" + "�긣��Ű1 �ο�4 ���ݸ��÷�" + "\n" + "Stirring";
    }
}
