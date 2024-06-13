using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class SOLoadManager : BaseSingleton<SOLoadManager>
{
    ///////////  variable  //////////

    private List<PlayerData>    _playerDataList    = new List<PlayerData>();
    //private List<CharacterData> _characterDataList = new List<CharacterData>();

    public int                 _playerCount       = 3;


    ///////////  property //////////
    
    
    public List<PlayerData>    PlayerDataList    { get { return _playerDataList; } private set { _playerDataList = value; } }
   
    
    //public List<CharacterData> CharacterDataList { get { return _characterDataList; } private set { _characterDataList = value; } }
    
    ///////////  method //////////

    void Start()
    {
        SOPlayerLoad();
    }
    

    private  void SOPlayerLoad()
    {
        for (int i = 0; i < _playerCount; i++)
        {
            Debug.Log("PlayerLoad");
            string     path       = $"Assets/0Teamplate/4SO/PlayerSO/playerDataSO {i}.asset";
            PlayerData playerData = AssetDatabase.LoadAssetAtPath<PlayerData>(path);
            PlayerDataList.Add(playerData);
        }
    }

    public void SOCharacterLoad() { }


    public void SOSkillLoad() { }
}