using UnityEngine;
using System.Collections;

public class AccordionTopBehaviour : MonoBehaviour {
	AccordionBehaviour parent;
	Transform playerParentTransform;
	
	void Start() {
		parent = GetComponentInParent<AccordionBehaviour>();
	}
	
	void OnTriggerEnter2D() {
		var collider = parent.GetComponent<BoxCollider2D>();
		//collider.size = new Vector2(1.7f, 1.7f);
		parent.compress();
	}
	
	void OnTriggerExit2D() {
		var collider = parent.GetComponent<BoxCollider2D>();
		//collider.size = new Vector2(collider.size.x, collider.size.y * 0.2f);
		parent.expand();
	}
}
