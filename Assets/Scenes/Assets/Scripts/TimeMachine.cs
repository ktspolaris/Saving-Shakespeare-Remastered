using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMachine : MonoBehaviour {
	public GameObject changeTime;
	public GameObject WatchWall2;

	void OnMouseDown(){
		changeTime.gameObject.SetActive (true);
		this.gameObject.SetActive(false);
		WatchWall2.gameObject.SetActive(true);
	}
}