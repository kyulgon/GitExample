using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_Test : MonoBehaviour
{
    
    void Start()
    {
        Delegate_12.OnStart += Abc;
    }

    public void Abc(int value) // Delegate 사용시 파라미터값을 일치!!
    {
        print(value + "증가했습니다.");
    }

    
    void Update()
    {
        
    }
}
