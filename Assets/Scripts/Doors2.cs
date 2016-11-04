using UnityEngine;
using System.Collections;

public class Doors2 : MonoBehaviour {

	Animator animator;
	bool doorOpen;

	public float speed = 3; 





	void Start()
	{
		doorOpen = false;
		animator = GetComponent<Animator>();
	}

	void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.tag == "Player" && GameVariables.keyCount>0)
		{
			doorOpen = true;
			DoorControl ("Open");
			//GameVariables.keyCount--;

		}
	}

	void OnTriggerExit(Collider collider)
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