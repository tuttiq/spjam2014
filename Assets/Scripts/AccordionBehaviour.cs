using UnityEngine;
using System.Collections;

public class AccordionBehaviour : ObjectsBehaviour {
	Transform originalParent;
	
	protected override void Start() {
		base.Start ();
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player")
			originalParent = coll.transform.parent;
	}

	void OnCollisionStay2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player")
			coll.transform.parent = transform;
	}
	
	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player")
			coll.transform.parent = originalParent;
	}
	
	public void compress() {
		animator.ResetTrigger("Expand");
		animator.SetTrigger("Compress");
	}
	
	public void expand() {
		animator.ResetTrigger("Compress");
		animator.SetTrigger("Expand");
	}
}
