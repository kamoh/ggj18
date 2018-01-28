using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBluePlayer : MonoBehaviour {

	public static GameObject BluePlayerGameObject;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public static void Spawn() {
		//		Instantiate (RedPlayerGameObject);
		Instantiate(Resources.Load("Prefabs/BluePlayerGameObject"));
//		Instantiate(Resources.Load("Prefabs/BluePlayerGameObjectVertical"));

//		Debug.Log("spawn blue player - spawn called");
	}
}
