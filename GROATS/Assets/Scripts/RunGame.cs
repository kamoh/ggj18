using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunGame : MonoBehaviour {

//	public GameObject[] triggeredBackgroundTiles;
	public static ArrayList TriggeredBackgroundTiles = new ArrayList();

	// Use this for initialization
	void Start () {
		Debug.Log("Game start");
		Debug.Log ("Triggered background tiles: " + TriggeredBackgroundTiles.Count);
	}

	// Have something that tells you which player is going in a given time

	// Update is called once per frame
	void Update () {
		
	}
}
