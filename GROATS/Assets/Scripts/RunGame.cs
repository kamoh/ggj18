using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGame : MonoBehaviour {

//	public GameObject[] triggeredBackgroundTiles;
	public static ArrayList TriggeredBackgroundTiles = new ArrayList();
	public static string ActivePlayer;
	public GameObject RedPlayerGameObjectFancy;
	public GameObject RedPlayerSpawn;

	// Use this for initialization
	void Start () {
		Debug.Log("Game start");
		Debug.Log ("Triggered background tiles: " + TriggeredBackgroundTiles.Count);
		ActivePlayer = "diseasePlayer";
		StartGame ();
	}

	void StartGame() {
		Debug.Log("Current player is " + ActivePlayer);
		TakeTurn ();
	}

	void TakeTurn () {
		Debug.Log ("NOW IN TAKE TURN WITH PLAYER OF " + ActivePlayer);
		Instantiate (RedPlayerGameObjectFancy, new Vector2 (RedPlayerSpawn.transform.position.x,
			                                           RedPlayerSpawn.transform.position.y),
			                                           Quaternion.identity);
	}

	public static void ToggleActivePlayer() {
		if (ActivePlayer == "diseasePlayer") {
			ActivePlayer = "curePlayer";
		} else {
			ActivePlayer = "diseasePlayer";
		}
		Debug.Log ("New active player is " + ActivePlayer);
	}

	// Have something that tells you which player is going in a given time

	// Update is called once per frame
	void Update () {
		
	}
}
