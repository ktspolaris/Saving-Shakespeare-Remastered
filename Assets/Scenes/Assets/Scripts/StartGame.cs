using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
	public float delay;
	float absoluteTime;
	bool endOfScene = false;

	// Use this for initialization
	void Awake () {
		absoluteTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		print (absoluteTime);
		absoluteTime += Time.deltaTime;
		if (absoluteTime >= delay && !endOfScene) {
			endOfScene = true;
			SceneManager.LoadScene ("MainScene");
		}
	}
}