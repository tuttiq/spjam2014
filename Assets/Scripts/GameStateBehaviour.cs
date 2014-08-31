using UnityEngine;
using System.Collections;

public class GameStateBehaviour : MonoBehaviour {	
	public enum STATES {
		Happy = 1,
		Sad = -1
	};
	
	public GameObject player;

	float _switchTime = -100f;
	//1 for Happy, -1 for Sad
	public static STATES gameState;	
	
	void Start () {
		gameState = STATES.Happy;
		
	}

	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.C)){
			if(Time.time - _switchTime > 1.5f)
			{				
				if (gameState == STATES.Happy)
					gameState = STATES.Sad;
				else
					gameState = STATES.Happy;
				_switchTime = Time.time;
			}

			//Debug.Log("gameState: " + gameState);
		}
		
		if (Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel(0);
		}
		
	}	
	
}
