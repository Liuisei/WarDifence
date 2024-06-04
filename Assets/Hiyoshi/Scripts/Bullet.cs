using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
    [SerializeField] private int _speed = 1;
    private float _fixSpeed = 0.01f;

    public int Speed
    {
        get { return _speed;}
        set
        {
            _speed = value;
        }
    }

    private void FixedUpdate()
    {
        transform.position += _fixSpeed * _speed * transform.up;
    }
}
