using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_03 : MonoBehaviour
{
    int intValue;

    float floatValue = 10.5f;
    float floatValue2 = 20.5f;


    int FloatToInt(float _parameter, float _parameter2, string _stringParam = "디폴트값")
    {
        //intValue = (int)(_parameter + _parameter2);
        //print(intValue);
        //print(_stringParam);

        return Multiply((int)(_parameter + _parameter2));
    }

    int Multiply(int _parameter)
    {
        return _parameter * _parameter;
    }
   
    void Start()
    {
        intValue = FloatToInt(floatValue, floatValue2);
        print(FloatToInt(floatValue, floatValue2));


    }

    
    void Update()
    {
        
    }
}
