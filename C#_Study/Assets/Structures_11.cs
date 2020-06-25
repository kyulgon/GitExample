using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// struct 값타임

// class 주소 타입

public struct Youtube // 구조체에서 값을 대입할 수 없음, 넣어주려면 public으로 받아서 파라미터값으로 받는다, 상속불가능
{
    //public int a;

    public void GetA(int value)
    {
        a = value;
    }

    public int a;
    public int b;
    public int c;
    public int d;

    public Youtube(int _a, int _b, int _c, int _d)
    {
        a = _a; b = _b; c = _c; d= _d;
    }
}


public enum Item
{
    Weapon,
    Shield,
    Potion,
}



public class Structures_11 : MonoBehaviour
{
    //Youtube keidy;

    Youtube keidy = new Youtube(1, 2, 3, 4);

    Item item;

    void Start()
    {
        keidy.a = 5;
        keidy.GetA(5);

        print(keidy.a);

        item = Item.Weapon;
        item = Item.Shield;

        print(item);
    }

    



}
