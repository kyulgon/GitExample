using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repetitive_07 : MonoBehaviour
{

    //int num = 0;

    string text = "가나다라마바사";

    void Start()
    {
        //for (; ; )
        //{
        //    num++;

        //    if (num % 2 == 0)
        //        continue; // 해당 회차를 끝냄

        //    print(num);


        //    if (num > 10)
        //        break; // 첫번째 반복문 , 조건문 탈출
        //}

        //while(num < 10)
        //{
        //    num++;

        //    print(num);
        //}

        //do
        //{
        //    num++;
        //    print(num);
        //} while (num < 10);


        foreach (char a in text) // text를 쪼개서 char형태로 a변수들을 반복해서 만듦
        {
            print(a);
        }
    }

    void Update()
    {
        
    }
}
