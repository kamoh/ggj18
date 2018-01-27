using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragTile : MonoBehaviour {

//	Collider2D TileCollider = gameObject.GetComponent<Collider2D>();
	public Collider2D collidor;
	// Use this for initialization
	void Start () {
		if (collidor.isTrigger) {
			Debug.Log("this thing is a trigger");
		} else if (!collidor.isTrigger) {
			Debug.Log("this is not a trigger");
		}
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

	void onMouseUp () {
//		int colliderCount = TileCollider.OverlapCollider(contactFilter, colliders);

//		Debug.Log("Total number of colliders detected: " + colliderCount);
	}
}
