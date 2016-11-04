using UnityEngine;
using System.Collections;

public class Doors : MonoBehaviour {

	Animator animator;
	bool doorOpen;
	 


	void Start()
	{
		doorOpen = false;
		animator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Player" && GameVariables.keyCount>0)
		{
			doorOpen = true;
			DoorControl ("Open");
			//GameVariables.keyCount--;
			 
		}
	}

	void OnTriggerExit(Collider col)
	{
		if(doorOpen)
		{
			doorOpen = false;
			DoorControl ("Close");
			GameVariables.keyCount-=1; 
		}
	}

	void DoorControl(string direction)
	{
		animator.SetTrigger(direction);
	}

}