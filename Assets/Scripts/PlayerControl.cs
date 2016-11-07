using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public GameObject GameManagerGO; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter(Collider collides)
	{
		if (collides.gameObject.tag == "Enemy") {
			//GameVariables.playerHealth = -1;
			//gameObject.SetActive (false); 
			//go to game over scene
			GameManagerGO.GetComponent<GameManager> ().SetGameManagerState (GameManager.GameManagerState.End);
		}
	 

	

	}
}
