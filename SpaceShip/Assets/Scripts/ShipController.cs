using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour 
{
	Quaternion rotationZLeft = Quaternion.AngleAxis(1,new Vector3(0,0,1));
	Quaternion rotationZRight = Quaternion.AngleAxis(-1,new Vector3(0,0,1));
	void Start ()
	{

	}

	void FixedUpdate ()
	{
		if(Input.GetKey(KeyCode.A))
			{
				if(transform.rotation.z <= 0.999f)
					{
						transform.rotation *= rotationZLeft;
						Debug.Log(transform.rotation.z);
					}
			}
		if(Input.GetKey(KeyCode.D))
			{
				if(transform.rotation.z >= 0.05f)
				{
					transform.rotation *= rotationZRight;
				}	
			}
	}
}
