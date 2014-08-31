using UnityEngine;
using System.Collections;

public class About : MonoBehaviour {

	void OnGUI() {
		GUI.Box(new Rect(Screen.width/2.5f, Screen.height/2, Screen.width/2, Screen.height/3), "FEIJAO DO VERAO D:");
		
		if(GUI.Button(new Rect(Screen.width/2.5f, Screen.height/2, Screen.width/5, Screen.height/10), "Back")) {
			Application.LoadLevel("MainMenu");
		}
	}
}
