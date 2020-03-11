using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ListsAndLoops : ScriptableObject
{
    public List<string> stringList;
    public string singleString;

    public void AddToList(string stringObj)
    {
        foreach (var obj in stringList)
        {
            if (obj.Contains(stringObj))
            {
                
            }
            else
            {
                stringList.Add(stringObj);
            }
        }
        
    }
    public void RemoveFromList(string stringObj)
    {
        for (int i = 0; i < stringList.Count; i++)
        {
            if (stringList[i] == stringObj)
            {
                stringList.Remove(stringObj);
            }
        }
    }
    public void CheckList()
    {
        foreach (var obj in stringList)
        {
            if (obj.Contains(singleString))
            {
                Debug.Log(obj);
            }
        }
    }

}
