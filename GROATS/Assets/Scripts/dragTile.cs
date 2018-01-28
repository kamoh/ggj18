using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class dragTile : MonoBehaviour {

//	public RedPlayerGameObject redPlayerCube;
//	Collider2D TileCollider = gameObject.GetComponent<Collider2D>();
	public Collider2D collidor;
	// Use this for initialization
	void Start () {
//		if (collidor.isTrigger) {
//			Debug.Log("this thing is a trigger");
//		} else if (!collidor.isTrigger) {
//			Debug.Log("this is not a trigger");
//		}
//		int numColliders = 10;
//		Collider2D[] colliders = new Collider2D[numColliders];
//		ContactFilter2D contactFilter = new ContactFilter2D();	
	}

	// Update is called once per frame
//	void Update () {
//		
//	}

	void OnMouseDrag ()
	{
		Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
	
		transform.position = objPosition;
	}﻿

	void OnMouseUp () {
		// if the length of the array is 4, destroy the thing and turn the grids under the piece to the color of the player piece
		// if the length of the array is not 4, move the collider dealie somewhere else or delete it
		if (RunGame.TriggeredBackgroundTiles.Count == 4) {
			Debug.Log ("Valid move! Great!");
			Debug.Log ("This is " + this);

//			Debug.Log("The array contains these elements: " +String.Join("",
//				new List<int>(RunGame.TriggeredBackgroundTiles)
//				.ConvertAll(i => i.ToString())
//				.ToArray()));

			foreach(String element in RunGame.TriggeredBackgroundTiles)
			{
				Debug.Log( element );
			}

			// get each valid tile that is being affected
			// get the color/team of the player that is placing the new piece
			// in a loop, change the image of each tile to the new one

			// When the move is done, destroy the piece that was placed by the player
			foreach (Transform child in transform) {
				Destroy (child.gameObject);
			}
		} else {
			Debug.Log ("Invalid move! Go fuck yourself!");
		}
//		Debug.Log("Total number of colliders detected: " + colliderCount);
	}
}
