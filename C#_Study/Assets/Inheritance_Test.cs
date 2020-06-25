using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance_Test : Inheritance_12
{
    string schoolName;
    
    void Start()
    {
        schoolName = "곤 초등학교";
        humanName = "곤";
        humanAge = 8;

        Info();
    }

    protected override void Info() // override는 재정의
    {
        base.Info(); // base는 부모클래스
        print("하이이루");
    }

    protected override void Name() // 미리 토대를 만드렁줌 = 다형성
    {
        print(humanName);
    }

}
