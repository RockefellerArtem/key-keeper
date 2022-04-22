using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    private Test _test;

    private void Start()
    {
        _test = GetComponentInChildren<Test>();

        Debug.Log(_test.Speed);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log(_test.Speed += 15);
        }
    }
}
