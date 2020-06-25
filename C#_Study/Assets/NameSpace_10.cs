using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yulgon.Studio;
using Yulgon;


// 협업, 대형 프로젝트, 외부 라이브러리
namespace Yulgon
{
    public class Youtube
    {
        public int subscribe;
    }


    namespace Studio
    {
        public class Youtube
        {
            int like;

            public void SetLike(int value)
            {
                like = value;
            }

            public bool isLike()
            {
                return like != 0;
            }

        }


    }
}

public class NameSpace_10 : MonoBehaviour
{
    //Youtube yulgon = new Youtube();
    Yulgon.Youtube yulgon;

    void Start()
    {
        //yulgon.SetLike(5);
        //print(yulgon.isLike());

        yulgon = new Yulgon.Youtube();

        yulgon.subscribe = 5;
        print(yulgon.subscribe);

    }

   
    void Update()
    {
        
    }
}
