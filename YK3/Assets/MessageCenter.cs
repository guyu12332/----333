using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageCenter : SingleTon<MessageCenter>
{
    Dictionary<string, Action> message = new Dictionary<string, Action>();

    public void AddListener(string str,Action action)
    {
        if (!message.ContainsKey(str))
        {
            message.Add(str, action);
        }
       
    }

    public void Broadcast(string str)
    {
        if (message.ContainsKey(str))
        {
            message[str]();
        }
       
    }

    public void RemoveListener(string str)
    {
        if (message.ContainsKey(str))
        {
            message.Remove(str);
        }
       
    }
}
