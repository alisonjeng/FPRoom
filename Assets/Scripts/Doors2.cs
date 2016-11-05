using UnityEngine;
using System.Collections;

public class Doors2 : MonoBehaviour {

	Animator animator;
	bool doorOpen;
	public int Layer; 
	public float animSpeed; 






	void Start()
	{
		doorOpen = false;
		animator = GetComponent<Animator>();
		if( animator.GetCurrentAnimatorStateInfo(Layer).IsName("Open"))
		{
			animator.speed = animSpeed;
		}
	}

	void OnTriggerEnter(Collider collid)
	{
		if(collid.gameObject.tag == "Player" && GameVariables.keyCount>0)
		{
			doorOpen = true;
			DoorControl ("Open");
			//GameVariables.keyCount--;


		}
	}

	void OnTriggerExit(Collider collid)
	{
		if(doorOpen)
		{
			doorOpen = false;
			DoorControl ("Close");
			GameVariables.keyCount--; 
		
		}
	}

	void DoorControl(string direction)
	{
		animator.SetTrigger(direction);
	}

}