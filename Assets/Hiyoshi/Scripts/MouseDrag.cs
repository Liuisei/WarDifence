using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
    [SerializeField] private GameObject _circle;
    private GameObject _mousePointerObject;

    private void Start()
    {
        _mousePointerObject = this.gameObject;
    }
    void Update()
    {
        Vector3 _pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _pos.z = 0;
        transform.position = _pos;

        if (Input.GetButtonDown("Fire1"))
        {
            
        }
    }
}