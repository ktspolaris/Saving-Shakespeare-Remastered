using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxKeyCollision : MonoBehaviour
{

public GameObject Box;
public GameObject BoxPresent;

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.name == "Close box Past")
		 {
			Box.SetActive(false);
BoxPresent.SetActive(false);
			
			gameObject.SetActive(false);
		}
	}
}



