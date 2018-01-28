using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBluePlayer : MonoBehaviour {

	public static GameObject BluePlayerGameObjectHor;
	public static GameObject BluePlayerGameObjectVert;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public static void Spawn() {
		//		Instantiate (RedPlayerGameObject);
		Instantiate(Resources.Load("Prefabs/BluePlayerGameObjectHor"));
		Instantiate(Resources.Load("Prefabs/BluePlayerGameObjectVert"));
//		Instantiate(Resources.Load("Prefabs/BluePlayerGameObjectVertical"));

//		Debug.Log("spawn blue player - spawn called");
	}
}
