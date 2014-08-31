using UnityEngine;
using System.Collections;

public class About : MonoBehaviour {

	void OnGUI() {
		
		if(GUI.Button(new Rect(Screen.width/3.3f, Screen.height/1.4f, Screen.width/8, Screen.height/10), "Back")) {
			Application.LoadLevel("MainMenu");
		}
	}
}
