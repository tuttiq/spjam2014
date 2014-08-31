using UnityEngine;
using System.Collections;

public class BoxObjectBehaviour : ObjectsBehaviour {
	protected override void ChangedToHappy(){
		//rigidbody2D.isKinematic = true;
		rigidbody2D.mass = 1000;
	}
	
	protected override void ChangedToSad() {
		//rigidbody2D.isKinematic = false;
		rigidbody2D.mass = 20;
	}
}
