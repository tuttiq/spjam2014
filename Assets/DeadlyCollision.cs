using UnityEngine;
using System.Collections;

public class DeadlyCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject == GameManager.Instance.CurrentPlayer) 
		{
			DestroyObject (other.gameObject);
			GameManager.Instance.Respaw();
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
