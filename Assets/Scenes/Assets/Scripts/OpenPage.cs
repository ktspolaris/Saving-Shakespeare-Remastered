using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPage : MonoBehaviour {
	public GameObject burnedPage;

	void OnMouseDown(){
		burnedPage.SetActive (true);
	}
}