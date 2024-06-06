using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private string _cardName;
    public string Name
    {
        get { return _cardName; }
        private set
        {
            _cardName = value;
        }
    }
}
