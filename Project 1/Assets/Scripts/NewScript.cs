using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewScript : MonoBehaviour
{
    public UnityEvent testEvent;
    private int hiddenInt;
    public UnityEvent testEventTwo;
    // Start is called before the first frame update
    void Start()
    {
        testEvent.Invoke();
        testEventTwo.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
