using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject Startpage;
	public GameObject Player;
	public GameObject Endpage;
	public GameObject Escaped; 


	public enum GameManagerState
	{
		Start,
		Play,
		End,
		Escaped,
	}

	GameManagerState GMState; 


	// Use this for initialization
	void Start () {
		Escaped.SetActive (false); 
		Endpage.SetActive (false); 
		Player.SetActive (false); 
		Startpage.SetActive (true); 
		GMState = GameManagerState.Start;


	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("s")) {
			GetComponent<GameManager> ().SetGameManagerState (GameManager.GameManagerState.Play); 

		}

	}

	void UpdateGameManagerState() {
		switch (GMState) {

		case GameManagerState.Start:
			Escaped.SetActive (false); 
			Endpage.SetActive (false); 
			Startpage.SetActive (true);
			Player.SetActive (false); 
			break; 

		case GameManagerState.Play:
			Startpage.SetActive (false);
			Player.SetActive (true); 
			break; 

		case GameManagerState.End:
			Startpage.SetActive (false); 
			Player.SetActive (false); 
			Endpage.SetActive (true); 
			Escaped.SetActive (false); 



			//Change game manager to opening state after 8 seconds 
			//Invoke ("ChangeToStartState", 8f); 


			break; 

		case GameManagerState.Escaped:
			Startpage.SetActive (false);
			Player.SetActive (false); 
			Endpage.SetActive (false);
			Escaped.SetActive (true); 

			break; 


		}


	}

	public void SetGameManagerState (GameManagerState state) {
		GMState = state; 
		UpdateGameManagerState ();

	}

	public void StartGamePlay() {
		UpdateGameManagerState ();

	}

	//Function to change game to opening state
	public void ChangeToStartState() {

		SetGameManagerState (GameManagerState.Start); 

	}

}

