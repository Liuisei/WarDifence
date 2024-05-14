using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class SceneLoadButton : BaseButton
{
    [SerializeField] int _sceneNumber;

    protected override void OnClicked()    { SceneManager.LoadScene(_sceneNumber); }
    protected override void OnMouseDown()  { }
    protected override void OnMouseEnter() { }
    protected override void OnMouseExit()  { }
}