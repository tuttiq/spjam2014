using UnityEngine;
using System.Collections;

public class DeadlyCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player" ) 
		{
			Application.LoadLevel(0);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
