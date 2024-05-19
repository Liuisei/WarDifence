using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

public class CardSlot : MonoBehaviour//ゲーム中に獲得したカードを置くスロット
{
    [SerializeField] private GameObject[] _cards = new GameObject[5];
    [SerializeField] private GameObject _cardPoolObject;
    private CardPool cardpool;

    private void Start()
    {
        cardpool = _cardPoolObject.GetComponent<CardPool>();
    }

    public void AddSlot(GameObject addCard) //敵を倒した時にカードを画面下部に置く
    {
        for (int i = 0; i < 5; i++)
        {
            if (_cards[i] != null)
            {
                addCard.transform.parent = _cards[i].transform;
                addCard.SetActive(true);
                addCard.transform.position = _cards[i].transform.position;
                return;
            }
        }
    }

    void DeleteCard(GameObject _deleteCard) //カード使用時にカードをプールに戻す
    {
        _deleteCard.transform.parent = _cardPoolObject.transform;
        _deleteCard.SetActive(false);
        _deleteCard.transform.position = _cardPoolObject.transform.position;
    }

    public void Test()
    {
        AddSlot(cardpool.RandomCard());
    }
}
