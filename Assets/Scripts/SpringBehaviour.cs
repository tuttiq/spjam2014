using UnityEngine;
using System.Collections;

public class SpringBehaviour : MonoBehaviour {

	public float speed;	
	public GameObject spring;
	public bool compress;
	public float yScaleLimit;
	public float yOffset;
	// Use this for initialization	
	void Start () {
		compress = false;
	}
	
	// Update is called once per frame
	void Update () {		
									
		if(compress && spring.transform.localScale.y > yScaleLimit){			
			spring.transform.localScale = new Vector3(spring.transform.localScale.x,
												 spring.transform.localScale.y - speed,
												 spring.transform.localScale.z);
			spring.transform.position = new Vector3(spring.transform.position.x,
													spring.transform.position.y - speed*2.5f,
													spring.transform.position.z);			
																					
			transform.position = new Vector3(transform.position.x,
											spring.transform.position.y+yOffset,
											transform.position.z);		
		} else if (!compress && spring.transform.localScale.y < 1){			
			spring.transform.localScale = new Vector3(spring.transform.localScale.x,
			                                          spring.transform.localScale.y + speed,
			                                          spring.transform.localScale.z);
			spring.transform.position = new Vector3(spring.transform.position.x,
			                                        spring.transform.position.y + speed*2.5f,
			                                        spring.transform.position.z);		
			
			transform.position = new Vector3(transform.position.x,
			                                 spring.transform.position.y+yOffset,
			                                 transform.position.z);
		 }
	}
	
	void OnCollisionStay2D(Collision2D collision){		
		if(collision.gameObject.tag == "Player" && GameStateBehaviour.gameState == GameStateBehaviour.STATES.Sad){
			compress = true;		
		}
	}
}
