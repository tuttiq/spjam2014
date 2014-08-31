using UnityEngine;
using System.Collections;

public class EndStage1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		
		Application.LoadLevel ("SegundaFase");
	}


	// Update is called once per frame
	void Update () {
	
	}
}
