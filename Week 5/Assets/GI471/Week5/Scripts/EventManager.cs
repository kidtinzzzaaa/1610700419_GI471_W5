using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    Dictionary<string, UnityEvent> eventDict = new Dictionary<string, UnityEvent>();

    public static EventManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    public void StartListening(string eventName, UnityAction listener)
    {
        if (eventDict.ContainsKey(eventName))
        {
            UnityEvent thisEventDict = eventDict[eventName];
            thisEventDict.AddListener(listener);
        }

        else
        {
            UnityEvent thisEvent = new UnityEvent();
            thisEvent.AddListener(listener);
            eventDict.Add(eventName, thisEvent);
        }
    }

    public void StopListening(string eventName, UnityAction listener)
    {
        if (eventDict.ContainsKey(eventName))
        {
            UnityEvent thisEvent = eventDict[eventName];
            thisEvent.RemoveListener(listener);
        }

    }

    public void TriggerEvent(string eventName)
    {
        if (eventDict.ContainsKey(eventName))
        {
            UnityEvent thisEvent = eventDict[eventName];
            thisEvent.Invoke();
        }
    }


}
