﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI() {
		if(GUI.Button(new Rect(Screen.width/2.5f, Screen.height/2, Screen.width/5, Screen.height/10), "New Game")) {
			Application.LoadLevel("Tutorial");
		}

		if(GUI.Button(new Rect(Screen.width/2.5f, 400, Screen.width/5, Screen.height/10), "About")) {
			Application.LoadLevel("About");
		}
	}
}
