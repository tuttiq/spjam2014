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

	protected virtual void Start() {
		actualState = GameStateBehaviour.STATES.Happy;
		previousState = GameStateBehaviour.STATES.Happy;
		animator = gameObject.GetComponent<Animator>();
	}
	
	protected void Update () {
		CheckIfStateChanged();		
	}
	
	// Update is called once per frame
	protected virtual void CheckIfStateChanged () {
		actualState = GameStateBehaviour.gameState;
		
		if (actualState != previousState){
			animator.SetTrigger("ChangeState");
			if (actualState == GameStateBehaviour.STATES.Happy) {
				ChangedToHappy();
			} else {
				ChangedToSad();
			}
			previousState = actualState;
		}
	}
	
	protected virtual void ChangedToHappy() {}
	protected virtual void ChangedToSad() {}
}
