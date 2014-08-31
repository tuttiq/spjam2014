using UnityEngine;
using System.Collections;

public class PlayerStateBehaviour : ObjectsBehaviour {	
	
	public GameObject happyPlayerPrefab;
	public GameObject sadPlayerPrefab;	
	
	public AudioClip happyMusic;
	public AudioClip sadMusic;
	
	protected override void ChangedToHappy(){
		GameObject currentPlayer = GameObject.FindWithTag("Player");		
		Destroy(GameObject.FindWithTag("Player"));
		currentPlayer = GameObject.Instantiate(happyPlayerPrefab, currentPlayer.transform.position, Quaternion.identity) as GameObject;
		currentPlayer.transform.parent = transform;
		
		Camera.main.GetComponent<Camera2DFollow>().target = currentPlayer.transform;
		
		Camera.main.audio.clip = happyMusic;
		Camera.main.audio.Play();
	}
	
	protected override void ChangedToSad() {
		GameObject currentPlayer = GameObject.FindWithTag("Player");
		Destroy(GameObject.FindWithTag("Player"));	
		currentPlayer = GameObject.Instantiate(sadPlayerPrefab, currentPlayer.transform.position, Quaternion.identity) as GameObject;
		currentPlayer.transform.parent = transform;
		
		Camera.main.GetComponent<Camera2DFollow>().target = currentPlayer.transform;
		
		Camera.main.audio.clip = sadMusic;
		Camera.main.audio.Play();
	}
}
