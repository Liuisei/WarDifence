using UnityEngine;


[CreateAssetMenu(fileName = "bulletDataSO", menuName = "bullet Data")]
public class BulletData : ScriptableObject
{
    [SerializeField] int        _bulletID;
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] float      _bulletSpeed;
    [SerializeField] int        _bulletDamage;
    [SerializeField] float      _bulletLifeTime;

    public int        BulletID       { get { return _bulletID; } }
    public GameObject BulletPrefab   { get { return _bulletPrefab; } }
    public float      BulletSpeed    { get { return _bulletSpeed; } }
    public int        BulletDamage   { get { return _bulletDamage; } }
    public float      BulletLifeTime { get { return _bulletLifeTime; } }
}