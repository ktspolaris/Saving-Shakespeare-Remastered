using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTime : MonoBehaviour {
	public GameObject camera;
	public GameObject anchor;

	void OnMouseDown(){
		print ("Change time!");
		camera.transform.position = anchor.transform.position;
	}
}