using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerSetPanel  : MonoBehaviour ,IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData) { InGameManager.Instance._isOutPlayerSetPanel = false; }
    public void OnPointerExit(PointerEventData  eventData) { InGameManager.Instance._isOutPlayerSetPanel = true; }
}