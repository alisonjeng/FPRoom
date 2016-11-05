using UnityEngine;
using System.Collections;

public class Doors3 : MonoBehaviour {

	Animator animator;
	bool doorOpen;



	void Start()
	{
		doorOpen = false;
		animator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.gameObject.tag == "Player" && GameVariables.keyCount>0)
		{
			doorOpen = true;
			DoorControl ("Open");
			//GameVariables.keyCount--;

		}
	}

	void OnTriggerExit(Collider coll)
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
