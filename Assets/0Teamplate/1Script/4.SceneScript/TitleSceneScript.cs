using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TitleUIOpen();
    }

    void TitleUIOpen()
    {
        UIManager.Instance.ShowUI(UITypeClass.EnumUIType.Title);
    }
    
}