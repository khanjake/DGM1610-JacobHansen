﻿using System;
using UnityEngine;
using UnityEngine.Events;


public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerStayEvent;
    public UnityEvent triggerExitEvent;
    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        triggerStayEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}