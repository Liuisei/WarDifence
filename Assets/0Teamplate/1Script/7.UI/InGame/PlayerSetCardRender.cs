using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerSetCardRender : MonoBehaviour , IEndDragHandler ,IBeginDragHandler, IDragHandler
{
    [SerializeField] Image _image;


    int _playerID;

    void Awake()
    {
        if (_image == null) { Debug.LogError(" PlayerSetUI : _image is null"); }
    }

    void Start()
    {
        _playerID = InGameManager.Instance.PlayerID;
        UpdateImage();
    }
    void UpdateImage() { _image.sprite = SOLoadManager.Instance.PlayerDataList[_playerID].PlayerIcon; }
    
    public void OnEndDrag(PointerEventData   eventData)
    {
        InGameManager.Instance.CardDragEnd();
        InGameManager.Instance._isDragIngPlayer = false;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        InGameManager.Instance.SetSpawnTargetToPointerChild(SOLoadManager.Instance.PlayerDataList[_playerID].PlayerPrefab);
        InGameManager.Instance._isDragIngPlayer = true;
    }
    public void OnDrag(PointerEventData eventData)
    {
        
    }
}