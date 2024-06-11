using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SOLoadManager
{
    public static SOLoadManager Instance { get; private set; } = new SOLoadManager();

    static public List<PlayerData>    PlayerDataList    { get; private set; } = new List<PlayerData>();
    static public List<CharacterData> CharacterDataList { get; private set; } = new List<CharacterData>();


    static public int PlayerCount = 7;


    ///////////  method //////////

    private SOLoadManager() { }

    [MenuItem("AssetDatabase/LoadAssetSOPlayerLoad")]
    private static void SOPlayerLoad()
    {
        // load player data fromm path

        for (int i = 0; i < PlayerCount; i++)
        {
            string     path       = $"Assets/0Teamplate/1Script/1.Manager/SOData/PlayerData {i}.asset";
            PlayerData playerData = AssetDatabase.LoadAssetAtPath<PlayerData>(path);
            PlayerDataList.Add(playerData);
            Debug.Log(PlayerDataList.Count);
        }
    }
    [MenuItem("AssetDatabase/Reset/ResetLoadAssetSOPlayerLoad")]
    private static void ResetSOPlayerLoad()
    {
        PlayerDataList.Clear();
        Debug.Log(PlayerDataList.Count);
    }


    public void SOCharacterLoad() { }


    public void SOSkillLoad() { }
}