using UnityEngine;
using System.Collections;

public class Pendullum : MonoBehaviour {

	public Vector3 rootPos;
	public float val;
	private float _maxAngle;
	private float _length;
	Transform _previosParent;
	// Use this for initialization
	void Start () {
		Vector3 diff = rootPos - transform.position;
		_length = diff.magnitude;
		_maxAngle = Mathf.Atan (diff.x / _length);
	}
	
	void OnCollisionEnter2D(Collision2D collision) {		
		_previosParent = collision.transform.parent;
	}

	void OnCollisionStay2D(Collision2D collision) {
		collision.transform.parent = transform;
	}
	void OnCollisionExit2D(Collision2D collision) {
		collision.transform.parent = _previosParent;
	}
	// Update is called once per frame
	void Update () {
		float angle = _maxAngle * Mathf.Cos (Time. time * 2f * Mathf.PI* Mathf.Sqrt(_length/ val));

		transform.position = new Vector3 (rootPos.x +_length * Mathf.Sin (angle) , rootPos.y - _length * Mathf.Cos (angle), transform.position.z);
	}
}
