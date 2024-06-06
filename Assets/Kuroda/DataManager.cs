using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    static DataManager _instance;
    static public DataManager Instance
    {
        get { return _instance; }
        set { _instance = value; }
    }

    string _path;
    [SerializeField] GameData _data = new GameData();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        _path = Application.dataPath + "/Kuroda/Save";

        if (!File.Exists(_path))
        {
            Save();
        }
        else
        {
            _data = new GameData(Load());
            Debug.Log("LoadData " + JsonUtility.ToJson(_data));
        }
    }
    void Start()
    {

    }

    void Update()
    {

    }

    public void Save()
    {
        SaveData saveData = new SaveData(_data.PlayerLevel, _data.CurrentDiamond);
        var jsonSaveData = JsonUtility.ToJson(saveData);
        Debug.Log("Save" + jsonSaveData);
        StreamWriter writer = new StreamWriter(_path, false);
        writer.WriteLine(jsonSaveData);
        writer.Close();
    }
    public SaveData Load()
    {
        StreamReader reader = new StreamReader(_path);
        string jsonSaveData = reader.ReadToEnd();                           // ファイル内容全て読み込む
        reader.Close();
        SaveData saveData = JsonUtility.FromJson<SaveData>(jsonSaveData);
        return saveData;
    }
}

/// <summary>
/// ゲーム中に使うデータクラス
/// </summary>
[Serializable]
class GameData
{
    public int PlayerLevel = 1;
    public int CurrentDiamond = 0;
    public GameData() { }
    public GameData(SaveData saveData)
    {
        PlayerLevel = saveData.PlayerLevel;
        CurrentDiamond = saveData.CurrentDiamond;
    }
}

/// <summary>
/// 保存するときにだけ使うクラス
/// </summary>
public class SaveData
{
    public int PlayerLevel;
    public int CurrentDiamond;
    public SaveData(int playerLevel, int currentDiamond)
    {
        PlayerLevel = playerLevel;
        CurrentDiamond = currentDiamond;
    }
}
