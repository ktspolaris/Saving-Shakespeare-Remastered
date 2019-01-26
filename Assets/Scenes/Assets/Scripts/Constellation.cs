using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constellation : MonoBehaviour {
	public GameObject[] stars;
	public GameObject lines;
	public GameObject match;

	public GameObject shakespeare;

	public GameObject[] fire;

	private AudioSource[] sounds;

	private int index = 0;
	public bool solved = false;

	void Awake(){
		sounds = GetComponents<AudioSource> ();
	}

	public void StarClicked(){
		print ("Index " + index);
		for (int i = 0; i <= index; i++) {
			if (!stars [i].GetComponent<Star> ().activated) {
				//If we're here, a star has been missed.
				ResetStars();
				return;
			}
		}
		//print ("Index " + index);
		index++;

		//Checking if ALL the stars have been clicked
		if (index == stars.Length) {
			PuzzleSolved ();
		} else {
			sounds [1].Play ();
		}
	}

	public void ResetStars(){
		sounds [0].Play ();

		for (int i = 0; i < stars.Length; i++) {
			stars [i].GetComponent<Star> ().activated = false;
		}
		index = 0;
		print ("Star missed!");
	}

	void PuzzleSolved(){
		print ("Puzzle solved!");
		lines.SetActive (true);
		match.SetActive (true);
		shakespeare.SetActive (false);
		solved = true;
	}
}