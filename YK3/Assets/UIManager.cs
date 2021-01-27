using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PanelType
{
    LogPanel,
    ChoosePanel
}

public class UIManager : SingleTon<UIManager>
{

    public Dictionary<PanelType, UIBase> uidic = new Dictionary<PanelType, UIBase>();
    public void Open(PanelType type)
    {
        if (uidic.ContainsKey(type))
        {
            uidic[type].Show();
        }
        else
        {
            Load(type);
        }
    }
    private void Load(PanelType type)
    {

        UIBase temp;
        GameObject res = Resources.Load<GameObject>(type.ToString());
        if (res != null)
        {
            GameObject obj = GameObject.Instantiate(res,GameObject.Find("Canvas").transform,false);
            temp = obj.GetComponent<UIBase>();
            temp.Init();
            uidic.Add(type, temp);
        }
    }
    public void Close(PanelType type)
    {
        if (uidic.ContainsKey(type))
        {
            uidic[type].Colse();
        }
    }
}
