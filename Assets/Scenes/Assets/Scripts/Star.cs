using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour {
	Constellation constellation;
	public bool activated = false;

	void Awake(){
		constellation = this.transform.parent.GetComponent<Constellation>();
	}

	//When the star is clicked, we check in the constellation script if the order is right.
	void OnMouseDown(){
		if(!constellation.solved){
			activated = true;
			constellation.StarClicked ();
		}
	}
}