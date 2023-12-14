using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class Data
{
    public string id = "sparta";
    public string password = "codingclub";
    public string name;
    public int cash;
    public int balance;
    public int debt = 0;
    public int interest = 0;
}
public class DataManager : MonoBehaviour
{
    string path;
    string filename = "userdata";
    public static DataManager instance;
    Data user = new Data();
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this) 
        {
            Destroy(instance.gameObject);
        }
        path = Application.persistentDataPath + "/";
    }
    public void Start()
    {
        user.name = "Rtan";
        user.cash = 100000;
        user.balance = 50000;

        SaveData();
    }
    public void SaveData()
    {
        string data = JsonUtility.ToJson(user);
        File.WriteAllText(path + filename, data);
    }

    public void LoadData()
    {
        string data = File.ReadAllText(path + filename);
        user = JsonUtility.FromJson<Data>(data);
    }
}
