using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Action_Func : MonoBehaviour
{
    // void면 Action 사용 아니면 Func
    delegate string MyDelegate<T1, T2>(T1 a, T2 b);
    MyDelegate<int, int> myDelegate;

    Action<int, int> myDelegate2; // delegate void MyDelegate<T1, T2>(T1 a, T2 b)포함

    Func<int, int, string> myDelegate3; // delegate string MyDelegate<T1, T2>(T1 a, T2 b)포함

    void Start()
    {
        myDelegate3 = (int a, int b) => { int sum = a + b; return sum + "이 리턴되었습니다."; };

        print(myDelegate3(3, 5));
        
    }

    
    void Update()
    {
        
    }
}
