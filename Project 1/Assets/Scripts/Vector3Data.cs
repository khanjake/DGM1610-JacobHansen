using UnityEngine;

public class Vector3Data : ScriptableObject
{
    public Vector3 value;
	
	public void ChangePosition(Transform transformObj)
	{
		transformObj.position = value;
	}
}
