using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spell : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private string _spellName;
    [SerializeField] private float _id;
    [SerializeField] private float _atk;
    [SerializeField] private int _cost;

    public string SpellName { get {return _spellName;} private set{} }

    public float Id { get { return _id; } private set { } }

    public float Atk
    {
        get { return _atk; }
        private set { _atk += value; }
    }

    public int Cost
    {
        get { return _cost; }
        private set { _cost += value; }
    }
}
