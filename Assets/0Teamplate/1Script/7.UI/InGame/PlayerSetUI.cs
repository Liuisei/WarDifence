using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSetUI : MonoBehaviour
{
    [SerializeField] Image _image;


    int                             _playerID;


    void Awake()
    {
        if (_image == null) { Debug.LogError(" PlayerSetUI : _image is null"); }
    }


    void Start()
    {
        _playerID     = InGameManager.Instance.PlayerID;
        UpdateImage();
    }

    void UpdateImage() { _image.sprite = SOLoadManager.Instance.PlayerDataList[_playerID].PlayerIcon; }
}