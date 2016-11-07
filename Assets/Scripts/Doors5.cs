using UnityEngine;
using System.Collections;


	public class Doors5 : MonoBehaviour {

		Animator animator;
		bool doorOpen;



		void Start()
		{
			doorOpen = false;
			animator = GetComponent<Animator>();
		}

		void OnTriggerEnter(Collider col)
		{
			if(col.gameObject.tag == "Player" && GameVariables.keyCount>=1)
			{
				doorOpen = true;
				DoorControl ("Open");
				//GameVariables.keyCount--;
			gameObject.GetComponent<AudioSource>().Play(); 

			}
		}

		void OnTriggerExit(Collider col)
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
