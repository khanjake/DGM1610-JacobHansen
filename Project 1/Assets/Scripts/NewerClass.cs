using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewerClass : MonoBehaviour
{
    public string stringThing;
    public int intNumber;
    public UnityEvent uEvent;
    void Start()
    {
        uEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
