using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchend : MonoBehaviour {
	public GameObject wood;
	public GameObject[] fire;

	void OnMouseDown(){
		wood.SetActive (false);
		gameObject.SetActive (false);
		for (int i = 0; i < fire.Length; i++) {
			fire [i].SetActive (false);
		}
	}
}