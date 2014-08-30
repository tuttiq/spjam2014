using UnityEngine;
using System.Collections;

public class DetectCollision : MonoBehaviour {

	public GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (target) {
			target.rigidbody2D.isKinematic = false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
