using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePicture : MonoBehaviour {

	public GameObject BurnPage;
	void Awake(){
		print ("Parent " + this.transform.parent);
	}

	void OnMouseDown(){
		print ("transform");
		BurnPage.SetActive (false);
	}
}