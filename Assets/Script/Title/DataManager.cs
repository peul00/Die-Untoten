using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerData
{
    public string name;
    public string NPCname;
    public int item;
}

public class DataManager : MonoBehaviour
{
    // ΩÃ±€≈Ê
    public static DataManager instance;

    public PlayerData nowplayer = new PlayerData();

    public string path;
    public int nowSlot;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(instance.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

        path = Application.persistentDataPath + "/save";
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    public void SaveData()
    {
        string data = JsonUtility.ToJson(nowplayer);
        File.WriteAllText(path + nowSlot.ToString(), data);
    }
    public void LoadData()
    {
        string data = File.ReadAllText(path + nowSlot.ToString());
        nowplayer = JsonUtility.FromJson<PlayerData>(data);
    }
    public void DataClear()
    {
        nowSlot = -1;
        nowplayer = new PlayerData();
    }
}
