using UnityEngine;
using System.Collections;

public class Camera2DFollow : MonoBehaviour {
	
	public Transform target;
	public Renderer ClampToGround;
	public Renderer ClampToCeiling;
	public float damping = 1;
	public float lookAheadFactor = 3;
	public float lookAheadReturnSpeed = 0.5f;
	public float lookAheadMoveThreshold = 0.1f;	
	
	float offsetZ;
	Vector3 lastTargetPosition;
	Vector3 currentVelocity;
	Vector3 lookAheadPos;
	
	// Use this for initialization
	void Start () {
		lastTargetPosition = target.position;
		offsetZ = (transform.position - target.position).z;
		transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null)
						return;
		// only update lookahead pos if accelerating or changed direction
		float xMoveDelta = (target.position - lastTargetPosition).x;

	    bool updateLookAheadTarget = Mathf.Abs(xMoveDelta) > lookAheadMoveThreshold;

		if (updateLookAheadTarget) {
			lookAheadPos = lookAheadFactor * Vector3.right * Mathf.Sign(xMoveDelta);
		} else {
			lookAheadPos = Vector3.MoveTowards(lookAheadPos, Vector3.zero, Time.deltaTime * lookAheadReturnSpeed);	
		}
		
		Vector3 aheadTargetPos = target.position + lookAheadPos + Vector3.forward * offsetZ;
		
		clampVector(ref aheadTargetPos);
		
		Vector3 newPos = Vector3.SmoothDamp(transform.position, aheadTargetPos, ref currentVelocity, damping);
		
		transform.position = newPos;
		
		lastTargetPosition = target.position;		
	}
	
	void clampVector(ref Vector3 vector) {
		float minY =
			ClampToGround != null ?
				ClampToGround.bounds.min.y + camera.orthographicSize :
				vector.y;
		float maxY =
			ClampToCeiling != null ?
				ClampToCeiling.bounds.max.y - camera.orthographicSize :
				vector.y;
				
		vector.y = Mathf.Clamp(vector.y, minY, maxY);
	}
}
