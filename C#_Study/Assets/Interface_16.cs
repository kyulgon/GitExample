using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 인터페이스 : 다중 상속 가능
abstract public class AA : MonoBehaviour
{
    public int a;
    abstract public void Abc();
}

interface ITest // 뼈대 제공, 다중 상속
{
    void Bbc();

    // 함수, 프로퍼티, 인덱서, 이벤트만 가능함
    int SalaryP { get; set; }
}

interface ITest2 : ITest // 인터페이스끼리 상속 가능
{

}

public class Interface_16 : AA, ITest
{
    int ITest.SalaryP { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override void Abc() 
    {
        print("aa");
    }

    public void Bbc() // 인터페이스는 재정의할때 override가 없음
    {
        print("bbc");
    }

    void ITest.Bbc()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
