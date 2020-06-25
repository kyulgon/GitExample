using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Property_14 : MonoBehaviour
{
    private int salary;

    private int bouns = 10;

    public int SalaryP { get { return salary + bouns; } set { if (value < 0) salary = 10; else salary = value; } } // get 읽기, set쓰기 - set에서 value만 가능(예약어)

    public int Bonus { get; set; }

    void Start()
    {
        salary = 10;

        print(SalaryP);

        Bonus = 10;
        print(Bonus);
    }

   
}
