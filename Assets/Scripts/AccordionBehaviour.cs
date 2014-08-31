using UnityEngine;
using System.Collections;

public class AccordionBehaviour : ObjectsBehaviour {
	public const float STATE_EXPANDED    = 0.0f;
	public const float STATE_COMPRESSING = 1.0f;
	public const float STATE_COMPRESSED  = 2.0f;
	public const float STATE_EXPANDING   = 3.0f;
	
	Transform originalParent;
	public float currentAnimationState;
	
	protected override void Start() {
		base.Start ();
		animator = GetComponentInParent<Animator>();
		currentAnimationState = STATE_EXPANDED;
	}
	
	protected override void Update() {
		base.Update();
		animator.SetFloat("AccordionState", currentAnimationState);
		 = (GetComponentInParent<Renderer>()).bounds.size;
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			originalParent = coll.transform.parent;
			if (currentAnimationState == STATE_EXPANDED) compress ();
		}
	}

	void OnCollisionStay2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player" && coll.transform.parent)
			coll.transform.parent.position = transform.position;
	}
	
	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player") {
			coll.transform.parent = originalParent;
			if (currentAnimationState == STATE_COMPRESSED) expand();
		}
	}
	
	public void compress() {
		currentAnimationState = STATE_COMPRESSING;
		animator.SetTrigger("Compress");
	}
	
	public void expand() {
		currentAnimationState = STATE_EXPANDING;
		animator.SetTrigger("Expand");
	}
}
