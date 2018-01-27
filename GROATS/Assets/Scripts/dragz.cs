using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragz : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	private validMoveDetection validMoveDetector;

	Transform parentToReturnTo = null;

	// Initialize the move detector script
	public void Awake() {
		validMoveDetector = GetComponent<validMoveDetection> ();
	}

	public void OnBeginDrag(PointerEventData eventData){
		Debug.Log ("OnBeginDrag");

		parentToReturnTo = this.transform.parent;
		this.transform.SetParent( this.transform.parent.parent );
	}

	public void OnDrag(PointerEventData eventData) {
		Debug.Log ("OnDrag");

		this.transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData) {
		Debug.Log ("OnEndDrag");
		this.transform.SetParent( parentToReturnTo );

		// Call the valid move detector script to see if the game is over or not
		validMoveDetector.detectValidMoves ();
	}
		
}
