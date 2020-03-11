using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public int intTriggeringEvents;
    public float floatTriggeringEvents;
    public string stringTriggeringEvents;
    public UnityEvent triggeringEventsEnter;
    public UnityEvent triggeringEventsStay;
    public UnityEvent triggeringEventsExit;

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        triggeringEventsEnter.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        triggeringEventsStay.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggeringEventsExit.Invoke();
    }
}
