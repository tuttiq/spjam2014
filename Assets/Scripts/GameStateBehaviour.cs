using UnityEngine;
using System.Collections;

public class GameStateBehaviour : MonoBehaviour {	
	
	//1 for Happy, -1 for Sad
	public static int gameState;	
	
	void Start () {
		gameState = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.C)){
			gameState *= -1; 
			Debug.Log("gameState: " + gameState);
		}
	}	
	
}
