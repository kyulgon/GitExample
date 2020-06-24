using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType_02 : MonoBehaviour
{
    //long l = 40000000000000;

    // byte 양수(0 ~ 255) - 1바이트
    // sbyte 정수 자료형 (-128 ~ 128) - 1바이트
    // short 정수 자료형 (-3만 ~ 3만) - 2바이트
    // integer 정수 자료형 (-20억 ~ 20억) - 4바이트
    // long 정수 자료형 (int보다 큼) - 8바이트

    //float f = 4.000001f;
    //double d = 4.000001;
    //decimal m = 4.0000001m;

    // float 실수 자료형 - 0.000000000000000000000000001
    // double 실수 자료형 - 0.00000000000000000000000000000000000000000000001
    // decimal 실수 자료형 - 오차가 거의 없음

    //-------------------------------------------------------------------------------------

    //string s = "123!@#$adsㅁㅇㄹㄴㅁㅇㄹ";
    //char c = 'A'; // 한글자만 가능(유니코드) A = 0065  

    //int a = 100;
    //float b = 100;
    //int sum;
    //float sum2;


    //int d = 100;
    //string e;

    //int f;
    //string g = "100";

    ////------------------------------------------------------------------------------------------

    //// ushort (0 ~ 6만) 음수가 없음
    //bool aaaa = true;
    //bool bbbb = false;

    void Start()
    {
        // sum = a + b; 단위가 안 맞으면 불가능
        //sum = (int)(a + b);
        //sum2 = a + b;
        //print(sum2);
        //print(sum);

        //e = d.ToString();
        //print(e);

        //f = int.Parse(g); // 문자를 강제로 int로 형변환
        //print(f);

    }

    
    void Update()
    {
        
    }
}
