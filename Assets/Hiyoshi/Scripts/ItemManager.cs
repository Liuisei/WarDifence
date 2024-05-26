using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{ 
    private static ItemManager _instance;
    public int _coin { get; private set; }
    public int _diamond { get; private set; }
    public static ItemManager Instance { get; private set; }
    private void Awake() { Instance = this; }
    public void AddCoin(int x) { _coin += x; }
    public void AddDiamond(int x) { _diamond += x; }
}
