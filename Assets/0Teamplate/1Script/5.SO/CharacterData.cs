using UnityEngine;

[CreateAssetMenu(fileName = "CharacterDataSO", menuName = "CharacterData", order = 5)]
public class CharacterData : ScriptableObject
{
    [SerializeField] int        _characterID;
    [SerializeField] GameObject _characterPrefab;
    [SerializeField] string     _characterName;
    [SerializeField] float      _characterCoolTime;
    [SerializeField] int        _characterHp;
    [SerializeField] int        _characterCost;
    [SerializeField] int        _characterSkillID;

    public GameObject CharacterPrefab   { get { return _characterPrefab; } }
    public int        CharacterID       { get { return _characterID; } }
    public string     CharacterName     { get { return _characterName; } }
    public float      CharacterCoolTime { get { return _characterCoolTime; } }
    public int        CharacterHp       { get { return _characterHp; } }
    public int        CharacterCost     { get { return _characterCost; } }
    public int        CharacterSkillID  { get { return _characterSkillID; } }
}