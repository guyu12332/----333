using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//单例类
public class SingleTon<T> where T:new()
{
    private static T ins;
    public static T Instance
    {
        get
        {
            if (ins == null)
            {
                ins = new T();
            }
            return ins;
        }
    }
}
