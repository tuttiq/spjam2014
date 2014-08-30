using UnityEngine;
using System.Collections;

public class ObjectsBehaviour : MonoBehaviour {

	// Use this for initialization
	protected GameStateBehaviour.STATES previousState;
	protected GameStateBehaviour.STATES actualState;

	protected Animator animator;

	protected GameStateBehaviour.STATES currentState()
	{
		return GameStateBehaviour.gameState;
	}

	protected void Start() {
		actualState = GameStateBehaviour.STATES.Happy;
		previousState = GameStateBehaviour.STATES.Happy;
		animator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	protected void UpdateObject () {
		actualState = GameStateBehaviour.gameState;
		
		if (actualState != previousState){
			// Debug.Log("prevStates: " + previousState + " actualState: " + actualState);
			ChangeState();
			previousState = actualState;
		}
	}
	
	protected virtual void ChangeState(){
		Debug.Log(gameObject.name + " Changing State " + actualState);
		animator.SetTrigger("ChangeState");
	}	
}
