using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Books : MonoBehaviour {
	BigBooks bigBooks;
	public bool activated = false;

	void Awake(){
		bigBooks = this.transform.parent.GetComponent<BigBooks>();
	}

	//When the star is clicked, we check in the constellation script if the order is right.
	void OnMouseDown(){
		if(!bigBooks.solved){
			activated = true;
			bigBooks.BookClicked ();
		}
	}
}