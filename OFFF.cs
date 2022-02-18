using UnityEngine;
using System.Collections;

public class OFFF : MonoBehaviour
{
    void Start ()
    {
		
    }
	
	void FixedUpdate()
	{
		if(Input.GetKey(KeyCode.Mouse0))
		{
			Display.displays[1].Activate();
		}
	}
}