using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRedPlayer : MonoBehaviour {

	public static GameObject RedPlayerGameObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void Spawn() {
//		Instantiate (RedPlayerGameObject);
		Instantiate(Resources.Load("Prefabs/RedPlayerGameObject"));

//		Debug.Log("spawn red player - spawn called");
	}
}
