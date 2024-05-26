using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    static CoinManager _instance;
    static public CoinManager Instance
    {
        get { return _instance; }
        set { _instance = value; }
    }

    [SerializeField,Header("所持金")]int _currentCoin;
    public int CurrentCoin
    {
        get { return _currentCoin; }
        set { _currentCoin = value; }
    }

    void Start()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(_instance);
        }
    }

    private void OnDestroy()
    {
        _instance = null;
    }

    /// <summary>所持金が足される</summary>
    /// <param name="coin">足されるコイン</param>
    public void AddCoin(int coin)
    {
        _currentCoin += coin;
    }

    public void SubCoin(int coin)
    {
        _currentCoin -= coin;
    }

    /// <summary>買えるかチェック これ必要？</summary>
    /// <param name="coin"></param>
    public bool IsBuy(int coin)
    {
        if(_currentCoin >= coin)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
