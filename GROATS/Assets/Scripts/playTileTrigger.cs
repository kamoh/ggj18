using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTileTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		// Destroy(other.gameObject);
		RunGame.TriggeredBackgroundTiles.Add(this.name);
		Debug.Log("GAME OBJECT " + this.name + " HAS BEEN TRIGGERED BY " + other.name);
		Debug.Log("Current # of triggered tiles: " + RunGame.TriggeredBackgroundTiles.Count);
	}

	void OnTriggerExit2D(Collider2D other) {
		// Destroy(other.gameObject);
		RunGame.TriggeredBackgroundTiles.Remove(this.name);
		Debug.Log("GAME OBJECT " + this.name + " NO LONGER TRIGGERED BY " + other.name);
		Debug.Log("Current # of triggered tiles: " + RunGame.TriggeredBackgroundTiles.Count);
	}
}
