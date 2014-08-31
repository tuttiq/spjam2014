using UnityEngine;
using System.Collections;

public class Pendullum : MonoBehaviour {

	public Vector3 rootPos;
	public float frequency = 1;
	private float _maxAngle;
	private float _length;
	Transform _previosParent;
	// Use this for initialization
	void Start () {
		Vector3 diff = rootPos - transform.position;
		_length = diff.magnitude;
		if (diff.y == 0) _maxAngle = -0.5f * Mathf.PI;
		else _maxAngle = Mathf.Atan (diff.x / diff.y);
		if (rootPos.x < transform.position.x) _maxAngle *= -1;
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

		float angle = _maxAngle * Mathf.Cos (2f * Mathf.PI * frequency * Time.time);
		//float angle = _maxAngle * Mathf.Cos (Time. time * 2f * Mathf.PI* Mathf.Sqrt(_length/ val));

		transform.position = new Vector3 (rootPos.x -_length * Mathf.Sin (angle) , rootPos.y - _length *Mathf.Cos (angle)
		                                  , transform.position.z);
	}
}
