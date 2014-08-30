using UnityEngine;
using System.Collections;

public class Activatable : MonoBehaviour {

	public Transform[] triggers;

	// Use this for initialization
	void Start () {
	
	}
	
	public void ActivateAction()
	{
		rigidbody2D.isKinematic = false;
	}
}
