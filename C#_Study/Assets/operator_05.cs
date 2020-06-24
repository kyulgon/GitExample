using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operator_05 : MonoBehaviour
{
    // 기본 연산자 +, - *, /, %, =(대입연산자)
    // ++, -- 증감 연산자 전위(선 연산 코드 실행), 후위(선 코드 실행 후 연산)
    // 관계 연산자 ==, <=, >= > < !=
    // 논리 연산자 && ||
    // 비트 연산자 &(AND곱) |(OR더) ^(XOR같은) ~(NOT뒤집기)
    // >> <<   00001000 = 8 ( << 2) 왼쪽, 오른쪽으로 이동시킴

    int a = 10;
    int b = 3;
    //int c = 0;

    bool c = false;

    private void Start()
    {
        //a += b; // a = a + b; 복합 대입 연산자
        //print(a);

        //c += 1; // c++, ++c
        //print(c);

        c = !((a > b) && (a == b)); // 관계 연산자 , 논리 연산자 &&(and - 모든 조건이 참일 경우에만 True), || (OR - 조건 중에 하나라도 성립하면 True)
        print(c);
    }


}
