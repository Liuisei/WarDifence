using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CardSlot : MonoBehaviour //ゲーム中に獲得したカードを置くスロット
{
    public static CardSlot Instance { get; private set; }
    [SerializeField] private GameObject[] _slots = new GameObject[5];
    private void Awake() { Instance = this; }
    
    [SerializeField] private GameObject _cardPoolObject;
     // public void AddCard(GameObject addCard) //カードを画面下部に置く処理
     // {
     //     for (int i = 0; i < _slots.Length; i++)
     //     {
     //         if (_slots[i].transform.childCount != 0)
     //         {
     //             addCard.SetActive(true);
     //             addCard.transform.parent = _slots[i].transform;
     //             addCard.transform.position = _slots[i].transform.position;
     //             Debug.Log(addCard.name);
     //             return;
     //         }
     //     }
     // }
     // public void DeleteCard(GameObject _deleteCard) //カード使用時にカードをプールに戻す
     // {
     //     _deleteCard.transform.parent = _cardPoolObject.transform;
     //     _deleteCard.SetActive(false);
     //     _deleteCard.transform.position = _cardPoolObject.transform.position;
     // }
}