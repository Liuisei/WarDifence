using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charactor : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private string _charactorName;
    [SerializeField] private float _id;
    [SerializeField] private float _atk;
    [SerializeField] private float _hp;
    [SerializeField] private float _coolTime;
    [SerializeField] private int _cost;

    public string CharactorName { get; private set; }
    
    public float Id { get; private set; }

    public float CoolTime { get; private set; }
    
    public float Hp
    {
        get { return _hp; }
        private set { _hp += value; }
    }

    public float Atk
    {
        get { return _atk; }
        private set { _atk += value; }
    }
    public int Cost { get; private set; }
}