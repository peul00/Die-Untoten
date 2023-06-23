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
    //public Text newPlayerName; // 슬롯에 들어갈 text

    bool[] savefile = new bool[4];

    // Start is called before the first frame update
    void Start()
    {
        // 슬롯별로 데이터가 존재하는지 확인
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
        // 저장된 데이터가 없을 때
        if (!savefile[number])
        {
            Create();
        }
        // 저장된 데이터가 있을 때
        else
        {
            DataManager.instance.LoadData();
            GoGame();
        }
    }
    public void Create()
    {
        print("저장된 데이터가 없습니다.");
    }
    public void GoGame()
    {
        /*// 슬롯에 저장된 파일 없을 때 이름 변경
        if (!savefile[DataManager.instance.nowSlot])
        {
            DataManager.instance.nowplayer.name = newPlayerName.text
            DataManager.instance.SaveData();
        }*/
        SceneManager.LoadScene("LoadingScene");
    }
}
