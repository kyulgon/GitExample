using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExceptionHandling : MonoBehaviour
{
    int a = 5;
    int b = 0;
    int c;

    
    void Start()
    {
        try
        {
            c = a / b;
        }
        catch (DivideByZeroException ie)
        {
            print(ie);
            b = 1;
            c = a / b;

        }
        finally
        {
            print(c);
        }

        throw new Exception("일부러 오류를 발생시킴");
    }
    
}
