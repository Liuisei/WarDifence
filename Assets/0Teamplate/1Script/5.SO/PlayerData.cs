using System;
using UnityEngine;

[Serializable]
[ CreateAssetMenu(fileName = "playerDataSO", menuName = "player Data") ]
public class PlayerData : ScriptableObject
{
    [SerializeField] int        _playerID;
    [SerializeField] GameObject _playerPrefab;
    [SerializeField] string     _playerName;
    [SerializeField] int        _playerHp;
    [SerializeField] int        _playerSkillID;
    [SerializeField] Sprite     _playerIcon;

    public GameObject PlayerPrefab  { get { return _playerPrefab; } }
    public int        PlayerID      { get { return _playerID; } }
    public string     PlayerName    { get { return _playerName; } }
    public int        PlayerHp      { get { return _playerHp; } }
    public int        PlayerSkillID { get { return _playerSkillID; } }
    public Sprite     PlayerIcon    { get { return _playerIcon; } }
}