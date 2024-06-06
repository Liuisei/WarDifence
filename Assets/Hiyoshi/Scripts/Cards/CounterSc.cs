using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CounterSc : MonoBehaviour
{
    private float _count = 0.1f;
    private Coroutine _coroutine;
    [SerializeField] private Character _character;


    private void Start()
    {
        StartCoroutine(AddCounter());
    }

    IEnumerator AddCounter()
    {
        for (;;)
        {
            _character.AddCounter(0.1f);
            yield return new WaitForSeconds(0.1f);
        }
    }
}