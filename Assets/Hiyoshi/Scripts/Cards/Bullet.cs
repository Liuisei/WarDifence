using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected float _speed = 1f;
    [SerializeField] protected float _damage = 1f;
    [SerializeField] protected float _destroyTime = 2f;
    [SerializeField] protected GameObject _enemyObj;

    public float Speed
    {
        get { return _speed; }
        private set { _speed = value; }
    }

    public float Damage
    {
        get { return _damage; }
        private set { _damage = value; }
    }

    public GameObject EnemyObj
    {
        get { return _enemyObj; }
        set { _enemyObj = value; }
    }

    private void Start()
    {
        Invoke("Destroy", _destroyTime);
        StartMethod();
    }

    private void FixedUpdate()
    {
        BulletBehaviour();
    }

    void Destroy()
    {
        Destroy(this.gameObject);
    }
    protected abstract void StartMethod();
    protected abstract void BulletBehaviour();
}