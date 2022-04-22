using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    private void Update()
    {
        Test("Hello world");
        Debug.Log(Test2(5,5));
    }

    private void Test(string message)
    {
        Debug.Log(message);
    }

    private int Test2(int a, int b)
    {
        return a + b;
    }
}
