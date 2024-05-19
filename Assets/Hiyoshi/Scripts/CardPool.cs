using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class CardPool : MonoBehaviour //カードはこのスクリプトがあった地されているオブジェクトの子オブジェクトに設定する
{
    GameObject[] _childrenList;
    private void Start()
    {
        _childrenList = new GameObject[this.gameObject.transform.childCount];
        for (int i = 0; i < this.gameObject.transform.childCount; i++)
        {
            _childrenList[i] = gameObject.transform.GetChild(i).gameObject;
            _childrenList[i].SetActive(false);
        }
    }

    public GameObject RandomCard()
    {
        Random random = new Random();
        int _random = random.Next(0, this.gameObject.transform.childCount);
        return _childrenList[_random];
    }
}