using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 코루틴 : 반복문을 동시에 실행, 병렬처리
public class Coroutine_21 : MonoBehaviour
{
    //Coroutine myCoroutine1;
    //Coroutine myCoroutine2;

    private IEnumerator myCoroutine1;


    void Start()
    {
        //myCoroutine1 = StartCoroutine(LoopA());
        //myCoroutine2 = StartCoroutine(LoopB());
        //StartCoroutine(Stooop());

        //myCoroutine1 = StartCoroutine(LoopA());
        //StartCoroutine("LoopB"); // 문자열로 넘기만 1개만 넘길수 있다
        //StartCoroutine(Stooop());

        myCoroutine1 = LoopA();
        StartCoroutine(myCoroutine1);
        StartCoroutine("LoopB");
        StartCoroutine(Stooop());



    }

    // 전처리 기능
    #region Loop

    IEnumerator LoopA()
    {
        for (int i = 0; i < 100; i++)
        {
            print(i);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator LoopB()
    {
        for (int x = 0; x < 100; x++)
        {
            print(x);
            yield return new WaitForSeconds(1f);
        }
    }

    #endregion Loop

    IEnumerator Stooop()
    {
        yield return new WaitForSeconds(2f);
        StopCoroutine(myCoroutine1);

        yield return new WaitForSeconds(2f);
        StopCoroutine("LoopB");
    }
}
