using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spell : Card
{
    [SerializeField] private Image _image;
    [SerializeField] private float _id;
    [SerializeField] private float _atk;
    [SerializeField] private int _cost;
    public float Id { get { return _id; } private set{} }
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

    public void PlaySpell()
    {
        
    }
}
