using UnityEngine;
using System.Collections;

public class ObjectsBehaviour : MonoBehaviour {

	// Use this for initialization
	private int previousState;
	private int actualState;
	private Animator animator;
	
	void Start() {
		actualState = 1;
		previousState = 1;
		animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		actualState = GameStateBehaviour.gameState;
		
		if(actualState != previousState){
			Debug.Log("prevStates: " + previousState + " actualState: " + actualState);
			ChangeState();
			previousState = actualState;
		}
		
	}
	
	void ChangeState(){
		Debug.Log(gameObject.name + " Changing State " + actualState);
		animator.SetTrigger("ChangeState");
	}	
}
