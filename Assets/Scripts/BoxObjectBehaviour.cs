using UnityEngine;
using System.Collections;

public class BoxObjectBehaviour : ObjectsBehaviour {
	private bool interactable;

	// Use this for initialization
	void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateObject ();
	}

	protected override void ChangeState(){
		base.ChangeState();
		if (currentState () == GameStateBehaviour.STATES.Happy) {
			rigidbody2D.isKinematic = true;
		}
		else {
			rigidbody2D.isKinematic = false;
		}
	}
}
