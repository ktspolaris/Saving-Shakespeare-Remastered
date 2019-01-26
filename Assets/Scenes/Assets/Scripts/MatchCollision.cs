using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchCollision : MonoBehaviour {
	public GameObject fire;
	public GameObject WoodTrigger;


 void OnTriggerEnter2D(Collider2D coll) {
	
		if (coll.gameObject.name == "wood") {
			Debug.Log(11111);
				fire.SetActive (false);
			WoodTrigger.SetActive(false);
			gameObject.SetActive(false);
		}
	}
}
