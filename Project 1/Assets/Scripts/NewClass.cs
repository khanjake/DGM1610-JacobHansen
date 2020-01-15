using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Don't remove {} they define the body of the class
public class NewClass : MonoBehaviour
{
    // public is to say its open, string is a data type, give it a name
    // Always end single lines with a ;
    // Always have public or private. Private is hidden and default
    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
    // Start is called before the first frame update
    void Start()
    {
        print(nameString);
        print(intNum);
        print(floatNum);
        print(gameObj);
        // Variable Assigned in Unity
    }

    // Update is called once per frame
    void Update()
    {

    }
}
