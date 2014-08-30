using UnityEngine;
using System.Collections;

public class TriggerPoint : MonoBehaviour {

	public Transform[] targets;

	// Use this for initialization
	void Start () {
	}
	void OnTriggerEnter2D(Collider2D other){
		foreach (var obj in targets) {
			obj.GetComponent<Activatable>().ActivateAction();
		}


	}

}
