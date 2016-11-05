using UnityEngine;
using System.Collections;

public class TrapDoorPlaneDestroy : MonoBehaviour {

	//Animator animator;
	//bool doorOpen;



	void Start()
	{
		//doorOpen = false;
		//animator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider co)
	{
		if(co.gameObject.tag == "Key" && GameVariables.keyCount>=1)
		{
			//doorOpen = true;
			//DoorControl ("Open");
			//GameVariables.keyCount--;
			gameObject.SetActive(false); 
		}
	}

	/*void OnTriggerExit(Collider col)
	{
		if(doorOpen)
		{
			doorOpen = false;
			DoorControl ("Close");
			//GameVariables.keyCount-=1; 

		}
	}

	void DoorControl(string direction)
	{
		animator.SetTrigger(direction);
	}*/

}
