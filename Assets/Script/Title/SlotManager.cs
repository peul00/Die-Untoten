using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class SlotManager : MonoBehaviour
{
    //public GameObject create;
    public Text[] slotText;
    //public Text newPlayerName; // ���Կ� �� text

    bool[] savefile = new bool[4];

    // Start is called before the first frame update
    void Start()
    {
        // ���Ժ��� �����Ͱ� �����ϴ��� Ȯ��
        for(int i = 0; i< 4; i++)
        {
            if(File.Exists(DataManager.instance.path + $"{i}"))
            {
                savefile[i] = true;
                DataManager.instance.nowSlot = i;
                DataManager.instance.LoadData();
                slotText[i].text = DataManager.instance.nowplayer.name;
            }
        }
        DataManager.instance.DataClear();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Slot(int number)
    {
        DataManager.instance.nowSlot = number;
        // ����� �����Ͱ� ���� ��
        if (!savefile[number])
        {
            Create();
        }
        // ����� �����Ͱ� ���� ��
        else
        {
            DataManager.instance.LoadData();
            GoGame();
        }
    }
    public void Create()
    {
        print("����� �����Ͱ� �����ϴ�.");
    }
    public void GoGame()
    {
        /*// ���Կ� ����� ���� ���� �� �̸� ����
        if (!savefile[DataManager.instance.nowSlot])
        {
            DataManager.instance.nowplayer.name = newPlayerName.text
            DataManager.instance.SaveData();
        }*/
        SceneManager.LoadScene("LoadingScene");
    }
}
