using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class CardPool : MonoBehaviour //カードはこのスクリプトがアタッチされているオブジェクトの子オブジェクトに設定すること
{
    public static CardPool Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    // public GameObject RandomCard()　//ランダムなカードを返す
    // {
    //     Random random = new Random();
    //     int _random = random.Next(0, this.gameObject.transform.childCount);
    //     return this.transform.GetChild(_random).gameObject;
    // }
}