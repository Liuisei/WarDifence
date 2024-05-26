using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBasic
{
    [SerializeField] private string _cardName;
    [SerializeField] private int _atk;
    [SerializeField] private int _hp;
    [SerializeField] private float _atkSpeed;
    [SerializeField] private float _coolTime;
    [SerializeField] private int _cardCost;
    private int _cardLevel = 1;
}
