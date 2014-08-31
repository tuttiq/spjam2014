using UnityEngine;
using System.Collections;

public class Parallaxing : MonoBehaviour {


	public Transform[] Backgrounds;
	public float smoothing;
	public Vector3 axisFactor = new Vector3 (1, 1, 0);

	public Transform Target;
	private Vector3 _prevPos;

	void Awake()
	{
	}

	// Use this for initialization
	void Start () {
		_prevPos = Target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if(Target.position != _prevPos)
		{			
			foreach (var b in Backgrounds) 
			{
				DoParallaxing (b);
			}
			_prevPos = Target.position;
		}
	}

	void DoParallaxing (Transform target)
	{
		var offsetParallaxing = -target.position.z;
		var parallax = Vector3.Scale (_prevPos - Target.position, axisFactor) * offsetParallaxing;
		target.position = Vector3.Lerp (target.position, target.position - parallax, smoothing * Time.deltaTime);
		//foreach(Transform child in target)
		{
		//	DoParallaxing(child);
		}
	}
}
