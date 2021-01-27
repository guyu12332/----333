using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBase : MonoBehaviour
{
 
    public virtual void Init()
    {

    }
    //显示
    public virtual void Show()
    {
        gameObject.SetActive(true);
    }
    //隐藏
    public virtual void Colse()
    {
        gameObject.SetActive(false);
    }
}
