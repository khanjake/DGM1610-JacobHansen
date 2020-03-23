using UnityEngine;

public class Debugger : ScriptableObject
{

    public void OnDebug(string message)
    {
        Debug.Log(message);
    }
}