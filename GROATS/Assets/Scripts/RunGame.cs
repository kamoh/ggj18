using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGame : MonoBehaviour {

//	public GameObject[] triggeredBackgroundTiles;
	public static ArrayList TriggeredBackgroundTiles = new ArrayList();
	public static string ActivePlayer;
	public static GameObject RedPlayerGameObject;
	public static GameObject RedPlayerSpawn;
//	public static GameObject BluePlayerGameObjectHorizontal;
//	public static GameObject BluePlayerGameObjectVertical;
//	public static GameObject BluePlayerSpawn;

	// Use this for initialization
	void Start () {
//		Debug.Log("Game start");
//		Debug.Log ("Triggered background tiles: " + TriggeredBackgroundTiles.Count);
		ActivePlayer = "diseasePlayer";
		StartGame ();
	}

	void StartGame() {
//		Debug.Log("Current player is " + ActivePlayer);
		TakeTurn ();
	}

	public static void TakeTurn () {
//		Debug.Log ("NOW IN TAKE TURN WITH PLAYER OF " + ActivePlayer);
		if (ActivePlayer == "diseasePlayer") {
			SpawnRedPlayer.Spawn ();
//			Instantiate (RunGame.RedPlayerGameObject, new Vector2 (RunGame.RedPlayerSpawn.transform.position.x, RunGame.RedPlayerSpawn.transform.position.y), Quaternion.identity);
		} else {
//			Instantiate (BluePlayerGameObjectHorizontal, new Vector2 (BluePlayerSpawn.transform.position.x,
//				BluePlayerSpawn.transform.position.y),
//				Quaternion.identity);
//			Instantiate (BluePlayerGameObjectVertical, new Vector2 (BluePlayerSpawn.transform.position.x,
//				BluePlayerSpawn.transform.position.y),
//				Quaternion.identity);
		}

	}

	public static void ToggleActivePlayer() {
		if (ActivePlayer == "diseasePlayer") {
			ActivePlayer = "curePlayer";
			SpawnBluePlayer.Spawn ();
//			SpawnRedPlayer.Spawn ();
		} else {
			ActivePlayer = "diseasePlayer";
			SpawnRedPlayer.Spawn ();
		}
		Debug.Log ("New active player is " + ActivePlayer);

//		TakeTurn ();
	}

	// Have something that tells you which player is going in a given time

	// Update is called once per frame
	void Update () {
		
	}
}
