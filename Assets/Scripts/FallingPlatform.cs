using UnityEngine;
using System.Collections;

public class FallingPlatform : ObjectsBehaviour {
	public GameStateBehaviour.STATES fallWhen;
	bool canFall;
	
	protected override void Start() {
		base.Start ();
		canFall = false;
	}

	protected override void ChangedToHappy() {
		canFall = (fallWhen == GameStateBehaviour.STATES.Happy);
	}
	
	protected override void ChangedToSad() {
		canFall = (fallWhen == GameStateBehaviour.STATES.Sad);
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
		if (canFall && coll.gameObject.tag == "Player") {
			collider2D.enabled = false;
			rigidbody2D.isKinematic = false;			
		}
	}
}
