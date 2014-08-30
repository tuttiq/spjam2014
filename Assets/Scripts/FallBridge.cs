using UnityEngine;
using System.Collections;

public class FallBridge : MonoBehaviour {

	public float Delay = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter2D(Collision2D collision) {
		StartCoroutine("AsyncFall");
	}

	IEnumerator AsyncFall(){
		yield return new WaitForSeconds(Delay);
		var body = GetComponent<Rigidbody2D> ();
		if (body) {
			body.isKinematic = false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
