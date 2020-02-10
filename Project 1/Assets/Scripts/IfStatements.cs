using UnityEngine;
using UnityEngine.UI;

public class IfStatements : MonoBehaviour
{
    public int a = 10;
    public int b = 4;
    public int c = 14;
    public string password = "Idon'tknowwhatI'mdoing";
    void Start()
    {
        if (true) 
        {
            print("The password is correct!");
        }
        else
        {
            print("Okay you little hacker! I see how it is");
        }
    }
    
    void Update()
    {
        
    }
}
