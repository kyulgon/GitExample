using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional_06 : MonoBehaviour
{
    int input = 15;
    int num = 10;

    bool result;
      
    void Start()
    {
        //if (input == num)
        //{
        //    print("input의 값이 num보다 같습니다.");
        //}

        //else if (input > num)
        //{
        //    print("input의 값이 num보다 큽습니다.");
        //}
        
        //else if(input < num)
        //{
        //    print("input의 값이 num보다 작습니다.");
        //}
        
        //else
        //{
        //    print("그 밖에 경우");
        //}
       

        switch(input)
        {
            case 10:
                print("input의 값이 10입니다.");
                break;
            case 11:
                print("input의 값이 11입니다.");
                break;
            case 12:
                print("input의 값이 12입니다.");
                break;
            default:
                print("그 외의 경우");
                break;
        }


        int temp = input == num ? 50 : 100; // 삼항 연산자
        print(temp);
    }
}
