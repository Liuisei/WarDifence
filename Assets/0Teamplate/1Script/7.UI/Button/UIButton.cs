using System;
using UnityEngine;
using UnityEngine.Serialization;

public class UIButton : BaseButton
{
    [SerializeField] private bool _open;
    [SerializeField] private bool _hideOther;

    [SerializeField] private UITypeClass.EnumUIType _uiType;

    void Awake()
    {
        if (_uiType == UITypeClass.EnumUIType.Empty) { Debug.LogError("UIType is Empty"); }
    }
    protected override void OnClicked()
    {
        if (_open) { UIManager.Instance.ShowUI(_uiType); }
        else { UIManager.Instance.HideUI(_uiType); }
    }
    protected override void OnMouseDown()  {  }
    protected override void OnMouseEnter() { }
    protected override void OnMouseExit()  { }
}