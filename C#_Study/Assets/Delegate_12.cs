using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate_12 : MonoBehaviour
{
    public delegate void ChainFuntion(int value); // Delegate는 하나의 클래스 안에 있는 것을 관리 감독
    public static event ChainFuntion OnStart; // event는 다 클래스까지 관리 감독 가능
    //ChainFuntion chain;


    int power;
    int defence;

    public void SetPower(int value)
    {
        power += value;
        print("power의 값이" + value + "만큼 증가했습니다. 총 power의 값 = " + power);
    }

    public void SetDefence(int value)
    {
        defence += value;
        print("power의 값이" + value + "만큼 증가했습니다. 총 power의 값 = " + defence);
    }
    
    void Start()
    {
        //chain += SetPower;
        //chain += SetDefence;

        //chain -= SetDefence;
        //chain -= SetPower;
        //if(chain != null)
        //    chain(5);

        OnStart += SetPower;
        OnStart += SetDefence;

    }


    private void OnDisable()
    {
        OnStart(5);
    }

}
