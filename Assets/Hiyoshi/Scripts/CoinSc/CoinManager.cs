using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance { get; private set; }
    [SerializeField] private int _min = 0, _max = 9999;
    [SerializeField] private Text _coinText;
    private int _inGameCoin;
    public int InGameCoin
    {
        get { return _inGameCoin; }
        private set
        {
            if (value > _max) value = _max;
            if (value < _min) value = _min;
            _inGameCoin = value;
        }
    }
    
    private void Update()
    {
        _coinText.text = CoinManager.Instance.InGameCoin.ToString();
    }

    private void Awake() { Instance = this; }

    public void AddCoin(int x) { InGameCoin += x; } 
}
