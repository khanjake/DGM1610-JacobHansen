using UnityEngine;
using UnityEngine.Events;

// Don't remove {} they define the body of the class
public class NewClass : MonoBehaviour
{
    public string nameString;
    public int intNum;
    public float floatNum;
    public GameObject gameObj;
    public UnityEvent uEvent;
    void Start()
    {
        print(nameString);
        print(intNum);
        print(floatNum);
        print(gameObj);
    }
    void Update()
    {
        
    }
}
