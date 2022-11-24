using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class actionScript : MonoBehaviour
{
    public UnityEvent[] actions = new UnityEvent[0];

    public enum ExecutionType { Numbers, Actions, Both, None };

    public ExecutionType type;

    public void play()
    {
        Debug.Log("Played Actions");

        for (int i = 0; i < actions.Length; i++)
        {
            // see 1114 for usage
            actions[i].Invoke();
        }

        if (type == ExecutionType.Both)
        {
            // do something
        } else if (type == ExecutionType.Numbers)
        {
            // do something
        } else if (type == ExecutionType.Actions)
        {
            // do something
        } 
    }
}
