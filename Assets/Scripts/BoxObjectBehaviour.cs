using UnityEngine;
using System.Collections;

public class BoxObjectBehaviour : ObjectsBehaviour {
	protected override void ChangedToHappy(){
		rigidbody2D.isKinematic = true;
	}
	
	protected override void ChangedToSad() {
		rigidbody2D.isKinematic = false;
	}
}
