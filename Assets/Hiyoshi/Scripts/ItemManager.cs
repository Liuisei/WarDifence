using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager
{ 
    private static ItemManager _instance;
    private int _coin = 0;
    private int _diamond = 0;

    public static ItemManager Instance { get { return _instance ??= new ItemManager(); } }
    public int diamond { get => _diamond; }
    public int coin { get => _coin; }

    void UseCoin(int x)
    {
        _coin += x;
    }

    void UseDiamond(int x)
    {
        _diamond += x;
    }
}
