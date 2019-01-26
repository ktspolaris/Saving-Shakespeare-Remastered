using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPuzzle : MonoBehaviour {
	public GameObject bigPicture;

	void OnMouseDown(){
		bigPicture.SetActive (true);
	}
}