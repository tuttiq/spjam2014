using UnityEngine;
using System.Collections;

public class Respawnable : MonoBehaviour {

	public Transform prefab;
	private Vector3 _initialPos;
	// Use this for initialization
	void Start () {

		_initialPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
	}
	
	public void Respaw()
	{
		var obj = GameObject.Instantiate (prefab, _initialPos, Quaternion.identity) as Transform; 
		
		GameObject.Destroy(gameObject);
		var Activator = GetComponent<Activatable> ();
		if (Activator) {
			foreach(var trigger in Activator.triggers)
			{
				var targets = trigger.GetComponent<TriggerPoint>().targets;
				for ( int i = 0 ; i < targets.Length; i++)
				{
					if(targets[i].Equals(this.transform))
					{
						targets[i] = obj.transform;
					}
				}

			}
		}

	}

}
