using System;
using UnityEngine;
using UnityEngine.Events;

public class AnythingYouWant : MonoBehaviour
{
    public UnityEvent mouseDownEvent, mouseUpEvent, mouseDragEvent;
    public UnityEvent mouseEnterEvent, mouseExitEvent, mouseOverEvent, mouseUpAsButtonEvent;
    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
    }

    private void OnMouseDrag()
    {
        mouseDragEvent.Invoke();
    }

    private void OnMouseEnter()
    {
        mouseEnterEvent.Invoke();
    }

    private void OnMouseExit()
    {
        mouseExitEvent.Invoke();
    }

    private void OnMouseOver()
    {
        mouseOverEvent.Invoke();
    }

    private void OnMouseUpAsButton()
    {
        mouseUpAsButtonEvent.Invoke();
    }
}
