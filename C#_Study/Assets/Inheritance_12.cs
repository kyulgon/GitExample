using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Inheritance_12 : MonoBehaviour
{
    protected string humanName; // protected는 상속받은 자식 클래스 상속
    protected int humanAge;


    protected virtual void Info() // virtual 가상함수
    {
        print("하잇!");
    }

    abstract protected void Name(); // abstract - 추상함수 : 자식 클래스에서 기능을 완성시켜야 하는 함수

}
