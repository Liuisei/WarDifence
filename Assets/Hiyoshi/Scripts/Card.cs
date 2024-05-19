using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : CardManager
{
    [SerializeField] private string _cardName;
    
    private int _cardLevel;
    private int _atk;
    private int _hp;
    private float _atkSpeed;
}
