using UnityEngine;


[CreateAssetMenu(fileName = "SkillDataSO", menuName = "Skill Data")]
public class SkillData : ScriptableObject
{
    [SerializeField] int        _skillID;
    [SerializeField] GameObject _skillPrefab;
    [SerializeField] float      _skillSpeed;
    [SerializeField] int        _skillDamage;
    [SerializeField] float      _skillLifeTime;

    public int        SkillID       { get { return _skillID; } }
    public GameObject SkillPrefab   { get { return _skillPrefab; } }
    public float      SkillSpeed    { get { return _skillSpeed; } }
    public int        SkillDamage   { get { return _skillDamage; } }
    public float      SkillLifeTime { get { return _skillLifeTime; } }
}