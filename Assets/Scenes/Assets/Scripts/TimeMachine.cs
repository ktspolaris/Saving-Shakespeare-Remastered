using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeMachine : MonoBehaviour {
	public GameObject changeTime;

	void OnMouseDown(){
		changeTime.gameObject.SetActive (true);
		this.gameObject.SetActive(false);
	}
}