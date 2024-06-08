using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SOLoadManager : BaseSingleton<SOLoadManager>
{
    private List<PlayerData>    _playerDataList    = new List<PlayerData>();
    private List<CharacterData> _characterDataList = new List<CharacterData>();
    public  List<PlayerData>    PlayerDataList    { get { return _playerDataList; } }
    public  List<CharacterData> CharacterDataList { get { return _characterDataList; } }
    static  int                 _playersCount = 0;
    static  public int                 _playersCounta = 0;
    [MenuItem("AssetDatabase/LoadAssetSOPlayerLoad")]
    public void SOPlayerLoad()
    {
        Debug.Log("message");
    }
    public void SOCharacterLoad() { }


    public void SOSkillLoad() { }

    protected override void AwakeFunction() { }
}