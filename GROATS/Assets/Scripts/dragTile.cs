using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class dragTile : MonoBehaviour {

	public SpriteRenderer sr;

	//  public RedPlayerGameObject redPlayerCube;
	//  Collider2D TileCollider = gameObject.GetComponent<Collider2D>();
	//  public Collider2D collidor;
	// Use this for initialization
	void Start () {
		//    if (collidor.isTrigger) {
		//      Debug.Log("this thing is a trigger");
		//    } else if (!collidor.isTrigger) {
		//      Debug.Log("this is not a trigger");
		//    }
		//    int numColliders = 10;
		//    Collider2D[] colliders = new Collider2D[numColliders];
		//    ContactFilter2D contactFilter = new ContactFilter2D();  
	}

	// Update is called once per frame
	//  void Update () {
	//    
	//  }

	void OnMouseDrag ()
	{
		Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);

		transform.position = objPosition;
	}﻿

	void OnMouseUp () {
		//    GameObject tileGridBeingClaimed;

		// if the length of the array is 4, destroy the thing and turn the grids under the piece to the color of the player piece
		// if the length of the array is not 4, move the collider dealie somewhere else or delete it
		if (RunGame.TriggeredBackgroundTiles.Count == 4) {
//			Debug.Log ("Valid move! Great!");
//			Debug.Log ("This is " + this);

			//      Debug.Log("The array contains these elements: " +String.Join("",
			//        new List<int>(RunGame.TriggeredBackgroundTiles)
			//        .ConvertAll(i => i.ToString())
			//        .ToArray()));

			// Get each valid tile that is being affected so we can change them, then change them
			foreach (GameObject element in RunGame.TriggeredBackgroundTiles) {
				//tileGridBeingClaimed = GetComponent<element> ();
				//        Debug.Log( element );
				//        Debug.Log( element.GetComponent<Renderer>().material);

				//        element.GetComponentInChildren (typeof(Texture)) as ChildTexture;

				//        GameObject originalGameObject = GameObject.Find("MainObj");
				GameObject spriteMaybe = element.transform.GetChild (0).gameObject;
				//        Debug.Log ("Disease tile is this " + Disease_Tile);
//				Debug.Log("What is this thing " + spriteMaybe);
				sr = spriteMaybe.GetComponent<SpriteRenderer> ();
//				Debug.Log ("Current sprite is " + sr.sprite);
//				Debug.Log ("THIS THINGS TAG IS " + this.tag);
				if (this.tag == "DiseasePlayer") {
					sr.sprite = Resources.Load<Sprite> ("Disease_Tile");
					element.tag = "DiseaseTile";
					Debug.Log ("HEY THE ELEMENT THAT IS TAGGABLE IS " + element);
				} else {
					sr.sprite = Resources.Load<Sprite> ("Cure_Tile");
					element.tag = "CureTile";
					Debug.Log ("HEY THE ELEMENT THAT IS TAGGABLE IS " + element);
				}
			}

			// Now that the tiles have been switched, see which nearby ones can be claimed by the move
			foreach (GameObject element in RunGame.TriggeredBackgroundTiles) {
				Debug.Log ("=======");
				Debug.Log ("BEGIN LOGGING FOR " + element.name);

				// Check for tiles above where it was placed
				Vector2 aboveCoordinates = new Vector2 (element.transform.position.x, element.transform.position.y + 1);

				// Check for tiles to the right of where it was placed
				Vector2 rightCoordinates = new Vector2 (element.transform.position.x + 1, element.transform.position.y);

				// Check for tiles below where it was placed
				Vector2 belowCoordinates = new Vector2 (element.transform.position.x, element.transform.position.y - 1);

				// Check for tiles to the left of where it was placed
				Vector2 leftCoordinates = new Vector2 (element.transform.position.x - 1, element.transform.position.y);

				ArrayList coordinatesToCheck = new ArrayList();
//				= new Array [aboveCuse ooordinates, rightCoordinates, belowCoordinates, leftCoordinates];

				coordinatesToCheck.Add(aboveCoordinates);
				coordinatesToCheck.Add(rightCoordinates);
				coordinatesToCheck.Add(belowCoordinates);
				coordinatesToCheck.Add(leftCoordinates);

				//				Vector2 size = new Vector2 (element.transform;

				//				RectTransform rt = (RectTransform)element.transform;
				//				float width = rt.rect.width;
				//				float height = rt.rect.height;

				float width = sr.sprite.bounds.size.x - 1;
				float height = sr.sprite.bounds.size.y - 1;

				Vector2 size = new Vector2 (width, height);



				foreach (Vector2 directionCheck in coordinatesToCheck) {
					Collider2D[] result = Physics2D.OverlapBoxAll (directionCheck, size, 0);

					foreach (Collider2D foundThing in result) {
						//					Debug.Log ("Result " + foundThing.name);

						if (foundThing.gameObject.tag == "OpenTile") {
							Debug.Log ("This thing is an open tile: " + foundThing.gameObject);
							Debug.Log ("This thing's tag is: " + foundThing.gameObject.tag);
							// temp to get replacement going
							GameObject spriteDealie = foundThing.transform.GetChild (0).gameObject;
							if (RunGame.ActivePlayer == "diseasePlayer") {
								spriteDealie.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Disease_Tile");
							} else {
								spriteDealie.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("Cure_Tile");
							}
						} else {
							Debug.Log ("This thing is not a free tile and won't be counted: " + foundThing.gameObject);
							Debug.Log ("This thing's tag is: " + foundThing.gameObject.tag);
						}
						//					foundThing.GetComponent<SpriteRenderer>
					}
				}

//				Debug.Log ("RESULTS FOUND " + result.Length);

				// check for adjacent tiles to turn to the new color
				//        element.transform.position.x -
//				Debug.Log ("Current " + element.name + " X position: " + element.transform.position.x);
//				Debug.Log ("Current " + element.name + " Y position: " + element.transform.position.y);

				//        sr.sprite = Disease_Tile;
				//        Debug.Log ("who is the current player? " + this.name);
				//        Debug.Log ("New sprite is " + sr.sprite);
				//        Debug.Log ("Tile acted upon is now tagged " + element.tag);

				//        element.GetComponent<Renderer>().material.mainTexture = Disease_Tile;
				//        element.GetComponent<Renderer>().material = Disease_Tile;

				//        element.GetComponent<Sprite>() = Disease_Tile;
				//        Debug.Log (tileGridBeingClaimed);
			}

			// get the color/team of the player that is placing the new piece
			// use GetComponent or something 
			// GetComponent<RunGame.TriggeredBackgroundTiles>();
			// in a loop, change the image of each tile to the new one

			// When the move is done, destroy the piece that was placed by the player
			foreach (Transform child in transform) {
				Destroy (child.gameObject);
			}

			// Reset the array of triggered tiles
			RunGame.TriggeredBackgroundTiles = new ArrayList();

			RunGame.ToggleActivePlayer ();

		} else {
//			Debug.Log ("Invalid move! Go fuck yourself!");
		}
		//    Debug.Log("Total number of colliders detected: " + colliderCount);
	}
}
