using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PlayerData
{
    public string Username;
    public string NPCname;
    public int item;
}

public class DataManager : MonoBehaviour
{
    // ΩÃ±€≈Ê
    public static DataManager instance;

    PlayerData nowplayer = new PlayerData();

    string path;
    string filename = "save";

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

        path = Application.persistentDataPath + "/";
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    public void SaveData()
    {
        string data = JsonUtility.ToJson(nowplayer);
        File.WriteAllText(path + filename, data);
    }
    public void LoadData()
    {
        string data = File.ReadAllText(path + filename);
        nowplayer = JsonUtility.FromJson<PlayerData>(data);
    }
}
