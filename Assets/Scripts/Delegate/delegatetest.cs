using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace test_space
{
    delegate void MyFun();
    delegate int MyFun2(int a);
    public class delegatetest : MonoBehaviour
    {
        private void Start()
        {
            MyFun f = new MyFun(Fun);
            MyFun2 f2 = new MyFun2(Fun2);
            f.Invoke();
            Debug.Log(f2.Invoke(5));
        }


        static void Fun()
        {
            Debug.Log("Fun");
        }

        static int Fun2(int a)
        {
            return a;
        }
    }
}

