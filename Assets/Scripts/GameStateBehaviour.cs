using UnityEngine;
using System.Collections;

public class GameStateBehaviour : MonoBehaviour {	
	public enum STATES {
		Happy = 1,
		Sad = -1
	};

	//1 for Happy, -1 for Sad
	public static STATES gameState;	
	
	void Start () {
		gameState = STATES.Happy;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.C)){
			if (gameState == STATES.Happy)
				gameState = STATES.Sad;
			else
				gameState = STATES.Happy;

			//Debug.Log("gameState: " + gameState);
		}
	}	
	
}
