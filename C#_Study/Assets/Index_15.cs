using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record
{
    public int[] temp = new int[5];

    public int this[int index]  // this는 해당 클래스를 지칭하는 예약어
    {
        get { 
                if(index >= temp.Length)
                {
                    Debug.Log("인덱스가 너무 큽니다.");
                    return 0;
                }
                    else
                {
                    return temp[index];
                }
        
            } // 읽기
        set { if (index >= temp.Length) Debug.Log("인덱스가 너무 큽니다."); else temp[index] = value; } // 쓰기
    }
}

public class Index_15 : MonoBehaviour
{
    Record record = new Record();

    void Start()
    {
        record[3] = 5;
        record[5] = 5;

        print(record[3]);
        print(record[5]);
    }

    
    void Update()
    {
        
    }
}
