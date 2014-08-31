using UnityEngine;
using System.Collections;

public class KillingObjectsBehaviour : MonoBehaviour {	
	
	private GameStateBehaviour gameManagerScript;
	
	void Start(){
		gameManagerScript = GameObject.FindWithTag("GameManager").GetComponent<GameStateBehaviour>();
	}
	
	void OnTriggerEnter2D(Collider2D other){		
		if(other.tag == "Player"){
			gameManagerScript.isAlive = false;					
			StartCoroutine(KillPlayer());
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision){		
		if(collision.gameObject.tag == "Player"){
			gameManagerScript.isAlive = false;					
			StartCoroutine(KillPlayer());
		}
	}
	
	IEnumerator KillPlayer()
	{	
		yield return new WaitForSeconds(2);		
		Application.LoadLevel(0);
		
	}
}
