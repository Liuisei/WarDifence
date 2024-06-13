using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerSetPanel  : MonoBehaviour ,IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Canvas _canvas;
    void Start()
    {
        _canvas.worldCamera = InGameManager.Instance._mainCamera;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        InGameManager.Instance._isOutPlayerSetPanel = false;
    }
    public void OnPointerExit(PointerEventData  eventData) { InGameManager.Instance._isOutPlayerSetPanel = true; }
}