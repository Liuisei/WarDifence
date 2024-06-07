using System;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// このスクリプトはUIの管理を行うスクリプトです。
/// </summary>
[DefaultExecutionOrder(-99)]
public class UIManager : BaseSingleton<UIManager>
{
    /// <summary> UIのリスト </summary>///
    [Header("UI Type List")]
    [SerializeField] private List<UITypeClass> _uiTypeList = new List<UITypeClass>();
    
    /// <summary>
    /// UIを出す関数
    /// Scenesで最初に出すUIは生成して
    /// targetUITypeClass._spawnedUIに登録します。
    /// </summary>
    /// <param name="uiType"> UIの種類 </param>
    public void ShowUI(UITypeClass.EnumUIType uiType)
    {
        var targetUITypeClass = _uiTypeList.Find(e => e._uiType == uiType);
        if (targetUITypeClass == null)
        {
            Debug.LogError("UI Type not found");
            return;
        }

        if (targetUITypeClass._spawnedUI == null) { targetUITypeClass._spawnedUI = Instantiate(targetUITypeClass._uiPrefab, new Vector3(0, 0, 0), Quaternion.identity); }
        else { targetUITypeClass._spawnedUI.SetActive(true); }
    }

    /// <summary>
    /// UIを消す関数
    /// </summary>
    /// <param name="uiType"> UIの種類 </param>
    public void HideUI(UITypeClass.EnumUIType uiType)
    {
        var targetUITypeClass = _uiTypeList.Find(e => e._uiType == uiType);
        if (targetUITypeClass == null)
        {
            Debug.LogError("UI Type not found");
            return;
        }

        if (targetUITypeClass._spawnedUI != null) { targetUITypeClass._spawnedUI.SetActive(false); }
    }

    protected override void AwakeFunction() {  }
}

[Serializable]
public class UITypeClass
{
    public enum EnumUIType { Empty,  Game, Settings, Title, }

    public                   EnumUIType _uiType;
    public                   GameObject _uiPrefab;
    [HideInInspector] public GameObject _spawnedUI;
}