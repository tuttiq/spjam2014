using UnityEngine;
using System.Collections;

public class ButtonObjectBehaviour : ObjectsBehaviour {
	private bool _pressed;
	
	public bool IsPressed {
		get { return _pressed; }
		set {
			if (value == true && !_pressed)
				animator.SetTrigger("Pressed");
			if (value == false && _pressed)
				animator.SetTrigger("Released");
				
			_pressed = value;
		}
	}
	
	protected override void Start() {
		base.Start ();
		_pressed = false;
	}
	
	protected override void ChangedToHappy() {
		rigidbody2D.isKinematic = false;
	}
	
	protected override void ChangedToSad() {
		rigidbody2D.isKinematic = true;
	}
	
	protected virtual void OnCollisionEnter2D(Collision2D collision) {
		if (!IsPressed) {
			if (currentState() == GameStateBehaviour.STATES.Sad) {
				IsPressed = true;
			}
		}
	}
}
