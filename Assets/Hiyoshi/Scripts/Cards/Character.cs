using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Character : Card, ICounter
{
    [SerializeField] private Image _image;
    [SerializeField] private float _id;
    [SerializeField] private float _atk;
    [SerializeField] private float _hp;
    [SerializeField] private float _coolTime;
    [SerializeField] private int _cost;
    [SerializeField] private GameObject _muzzle;
    [SerializeField] private GameObject _bulletObj;
    [SerializeField] private int _bulletSpeed;
    [SerializeField] private GameObject _enemyObj;
    private float _attackCounter = 0;

    public float Id
    {
        get { return _id; }
        private set { _id = value; }
    }

    public float CoolTime
    {
        get { return _coolTime; }
        private set { _coolTime = value; }
    }

    public float Hp
    {
        get { return _hp; }
        private set { _hp = value; }
    }

    public float Atk
    {
        get { return _atk; }
        private set { _atk = value; }
    }

    public int Cost
    {
        get { return _cost; }
        private set { _cost = value; }
    }

    public float AttackCounter
    {
        get { return _attackCounter; }
        private set
        {
            if(value < 0) value = 0;
            _attackCounter = value;
        }
    }

    public void Attack()
    {
    }

    void ShotBullet()
    {
        Vector3 _targetPos = _enemyObj.transform.position;
        GameObject _bullet = Instantiate(this._bulletObj, _muzzle.transform.position, quaternion.identity);
        _bullet.transform.up = _targetPos - _bullet.transform.position;
        Bullet _bulletSc = _bullet.GetComponent<Bullet>();
        _bulletSc.Speed = _bulletSpeed;
    }

    public void AddCounter(float x)
    {
        AttackCounter += x;
        Debug.Log(AttackCounter);
        if (AttackCounter >= CoolTime)
        {
            ShotBullet();
            AttackCounter = 0;
        }
    }
}