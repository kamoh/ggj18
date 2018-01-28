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
//		Debug.Log("THIS THING IS A " + this.gameObject);
//		Debug.Log("THIS THING'S TAG IS " + this.gameObject.tag);
		if (this.gameObject.tag == "OpenTile") {
			RunGame.TriggeredBackgroundTiles.Add(this.gameObject);
//			Debug.Log("GAME OBJECT " + this.name + " HAS BEEN TRIGGERED BY " + other.name);
//			Debug.Log("Current # of triggered tiles: " + RunGame.TriggeredBackgroundTiles.Count);
		}
	}

	void OnTriggerExit2D(Collider2D other) {
		// Destroy(other.gameObject);
		RunGame.TriggeredBackgroundTiles.Remove(this.gameObject);
//		Debug.Log("GAME OBJECT " + this.name + " HAS BEEN TRIGGERED BY " + other.name);
//		Debug.Log("Current # of triggered tiles: " + RunGame.TriggeredBackgroundTiles.Count);
	}
}
