using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		
		Application.LoadLevel ("EndScene");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
