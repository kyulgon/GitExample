using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Arrangement_08 : MonoBehaviour
{
    // 1차원 배열

    int[] exp = { 50, 100, 150, 200, 250, 300 };

    int[] arry = new int[10];

    int[] arry2;


    // 2차원 배열
    int[,] array2 = { { 1, 2, 3, 4, 5, }, { 10, 20, 30, 40, 50 } };

    // 3차원 배열
    int[,,] arry3 = { { { 1, 2, 3, 4, 5, }, { 10, 20, 30, 40, 50 } }, { { 1, 2, 3, 4, 5, }, { 10, 20, 30, 40, 50 } } };

    void Start()
    {
        exp[5] = 500;
        print(exp[5]);


        for (int i = 0; i < exp.Length; i++)
        {
            print(exp[i]);
        }

        arry[0] = 100;
        arry[1] = 200;

        arry2 = new int[exp.Length];

        print(array2[1, 3]);
        print(arry3[1, 1, 3]);
    }

}
