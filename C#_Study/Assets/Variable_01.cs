using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A //  어려가지 클래스 제작 가능
{
    //int A = 1000;
}

public class Variable_01 : MonoBehaviour
{
    int x = 100;
    int y = 100;
    int sum;

    void Start()
    {
        sum = x + y;

        print(sum);

        print(-sum);
    }

    
    void Update()
    {
        
    }
}
