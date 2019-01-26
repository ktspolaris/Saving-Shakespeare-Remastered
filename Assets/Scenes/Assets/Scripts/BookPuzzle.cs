using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookPuzzle : MonoBehaviour {
	public GameObject bigBooks;

	void OnMouseDown(){
		bigBooks.SetActive (true);
	}
}