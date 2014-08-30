using UnityEngine;
using System.Collections;

public class ButtonObjectBehaviour : ObjectsBehaviour {
	protected override void ChangedToHappy() {
		rigidbody2D.isKinematic = false;
	}
	
	protected override void ChangedToSad() {
		rigidbody2D.isKinematic = true;
	}
}
