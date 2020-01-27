using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}