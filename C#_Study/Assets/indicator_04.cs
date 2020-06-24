using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test2
{
    private int a;
    public int b;
    public static int c; // 공유자원, 정적 변수

    public void Abc()
    {

    }

    private void Abc2()
    {

    }
}

public class indicator_04 : MonoBehaviour
{
    //int a = 5;  // 멤버 변수, 전역 변수

    //void Abc()
    //{
    //    int a = 5; // 지역변수
    //    a = 6;

    //    int b = 5; // 지역변수
    //    print(b);
    //}

    //void Abc2()
    //{
    //    int b = 5; // 지역변수
    //    print(b);
    //}

    //void Abc3(float _parameter) // 매개 변수
    //{

    //}


    Test2 a1 = new Test2();
    Test2 a2 = new Test2();
    Test2 a3 = new Test2();

    private void Start()
    {
        Abc();
    }

    void Abc()
    {
        
        a1.b = 1;
        a2.b = 5;
        a3.b = 10;

        Test2.c = 100;

        print(a1.b);
        print(a2.b);
        print(a3.b);
        print(Test2.c);
    }

}
