using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    [SerializeField] private float _generateSpeed = 1;
    [SerializeField] private bool _isGenerater = false;

    private void Start()
    {
        StartCoroutine(CoinGenerate());
    }

    IEnumerator CoinGenerate()
    {
        while (_isGenerater)
        {
            CoinManager.Instance.AddCoin(1);
            yield return new WaitForSeconds(_generateSpeed);
        }
    }
}