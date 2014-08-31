using UnityEngine;
using System.Collections;

public class ButtonPuzzleBehavior : MonoBehaviour {

	ButtonPuzzleManagerBehavior puzzleManager;
	bool isPressed;
	
	// Use this for initialization
	void Start () {
		puzzleManager = GameObject.FindGameObjectWithTag("ButtonPuzzleManager").GetComponentInParent<ButtonPuzzleManagerBehavior>();
		
	}
	
	void OnCollisionEnter2D(Collision2D collision) {	
		if (collision.gameObject.tag == "Player" && !isPressed) {
			isPressed = true;
			puzzleManager.VerifyPuzzle(gameObject.tag);
		}
	}
}
