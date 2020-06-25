using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection_09 : MonoBehaviour
{
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };


    // 컬렉션 : 리스트, 큐, 스택, 해시테이블, 딕셔너리, arraylist

    // ArraryList
    ArrayList arrayList = new ArrayList();

    //List
    List<int> list = new List<int>();

    //HashTable
    Hashtable hashTable = new Hashtable();

    //Dictionary
    Dictionary<string, int> dictionary = new Dictionary<string, int>();

    //Queue, 선입선출, FIFO, 포션 제작 대기줄
    Queue<int> queue = new Queue<int>();

    //Stack, 후입 선출, LIFO, 요리게임
    Stack<int> stack = new Stack<int>();


    void Start()
    {
        // arryList (자료형 상관없이 넣을 수 있음) 단점 : List보다 연산량이 많아지고 부과화

        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add("가나다라");
        arrayList.Add(4.5);

        print(arrayList.Count);
        arrayList.Remove("가나다라");
        arrayList.RemoveAt(3);
        arrayList.RemoveRange(1, 3);
        arrayList[3] = 4;
        arrayList.Clear();
        print(arrayList.Contains("가나다라"));
        arrayList.Insert(1, 1.5);

        for (int i = 0; i < arrayList.Count; i++)
        {
            print(arrayList[i]);
        }


        list.Add(3); // 지정된 자료형만 넣을수 있음

        hashTable.Add("만", 10000);
        hashTable.Add("백만", 100000);
        hashTable.Add(50, "오십");

        print(hashTable["만"]); // key값을 넣어서 값을 찾음
        print(hashTable[50]);

        dictionary.Add("가", 100); // 해시테이블이랑 사용방법이 같음. 차이점 : arrayList, List와 마찬가지로 HashTable은 자료형은 안가지고 있음

        queue.Enqueue(5);
        queue.Enqueue(10);
        if (queue.Count != 0)
            print(queue.Dequeue());
        if (queue.Count != 0)
            print(queue.Dequeue());
        if (queue.Count != 0)
            print(queue.Dequeue());

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        if(stack.Count !=0)
            print(stack.Pop());
        if (stack.Count != 0)
            print(stack.Pop());
        if (stack.Count != 0)
            print(stack.Pop());



    }

   
    void Update()
    {
        
    }
}
