using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class Lambda_18 : MonoBehaviour
{
    //int a = 5;
    //int b = 5;
    //int sum;

    //void Add()
    //{
    //    sum = a + b;

    //}


    //void Back()
    //{
    //    sum = 0;
    //}

    //delegate void MyDelegate();
    //MyDelegate myDelegate;

    delegate void MyDelegate<T>(T a, T b);
    MyDelegate<int> myDelegate;

    // Start is called before the first frame update
    void Start()
    {
        //myDelegate = Add;        
        //myDelegate += delegate () { print(sum); }; // 무명 메소드, 델리게이트를 통해서만 호출가능
        //myDelegate += () => print(sum); // 람다식
        //myDelegate += Back;

        //myDelegate();

        myDelegate += (int a, int b) => print(a+b);
        myDelegate(3, 5);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
