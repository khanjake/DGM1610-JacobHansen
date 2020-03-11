using UnityEngine;

public class Vector3Data : ScriptableObject
{
    public Vector3 value;
	
	public void ChangePosition(Transform transformObj)
	{
		transformObj.position = value;
	}

	public void ChangeValueFromTransform(Transform transformObj)
	{

	}

	public void ChangeVector3Data(Vector3Data vector3DataObj)
	{
		Vector3Data
	}
}
