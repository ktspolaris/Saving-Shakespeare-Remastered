using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBooks : MonoBehaviour {
	public GameObject smallBooks;
	public GameObject BoxKey;
	public GameObject[] books;
	private int index = 0;
	public bool solved = false;




	public void BookClicked(){
		print ("Index " + index);
		for (int i = 0; i <= index; i++) {
			if (!books [i].GetComponent<Books> ().activated) {
				//If we're here, a book has been missed.
				ResetBooks();
				return;
			}
		}
		books[index].gameObject.SetActive (false);
		index++;


		//Checking if ALL the books have been clicked
		if (index == books.Length) {
			PuzzleSolved ();
		} else {
			//sounds [1].Play ();
		}
	}

	public void ResetBooks(){
		//sounds [0].Play ();

		for (int i = 0; i < books.Length; i++) {
			books [i].gameObject.SetActive (true);
			books [i].GetComponent<Books> ().activated = false;
		}
		index = 0;
		print ("Book missed!");
	}

	void PuzzleSolved(){
		print ("Puzzle book solved!");
		solved = true;

		smallBooks.SetActive (false);
		BoxKey.SetActive (true);
 
	}
}