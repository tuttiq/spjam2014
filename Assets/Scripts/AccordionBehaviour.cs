using UnityEngine;
using System.Collections;

public class AccordionBehaviour : ObjectsBehaviour {
	protected override void Start() {
		base.Start ();
	}
	
	public void compress() {
		animator.SetTrigger("Compress");
	}
	
	public void expand() {
		animator.SetTrigger("Expand");
	}
}
