﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldSuperviser : MonoBehaviour {

	const float timeToRestartMinutes = 0.2f;
	float timeToRestart = timeToRestartMinutes * 60; //minutes

	void Start () {

	}

	void Update () {
			
			System.GC.CollectionCount(1000);

			if(Input.GetKey(KeyCode.R)){
			 SceneManager.LoadScene(0);
			}
			
	

	}
}