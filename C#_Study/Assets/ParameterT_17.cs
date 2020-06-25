using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abc<T>
{
    public T var;
    public T[] array;
}

public class ParameterT_17 : MonoBehaviour
{
    //void Print(int value)
    //{
    //    print(value);
    //}

    //void Print(string value)
    //{
    //    print(value);
    //}

    //void Print(float value)
    //{
    //    print(value);
    //}

    //void Print<T>(T value) where T : class // 제한 가능
    //{
    //    print(value);
    //}


    Abc<string> a;
    Abc<float> b;

    // Start is called before the first frame update
    void Start()
    {
        //Print(4.5f);
        //Print<string>("abc");
        //Print<float>(4.5f);

        a.var = "abc";
        b.var = 4.5f;
        a.array = new string[1];
        b.array = new float[1];
        a.array[0] = "abc";
        b.array[0] = 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
