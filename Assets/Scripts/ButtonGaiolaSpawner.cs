using UnityEngine;
using System.Collections;

public class ButtonGaiolaSpawner : ButtonObjectBehaviour {

	public GameObject gaiolaPrefab;
	public Transform gaoilaSpawnPoint;

	protected override void OnCollisionEnter2D(Collision2D collision) {		
	}

	protected void OnCollisionStay2D(Collision2D collision) {
		if (!IsPressed) {
			if (currentState() == GameStateBehaviour.STATES.Sad) {
				IsPressed = true;
				GameObject.Instantiate(gaiolaPrefab, new Vector3(gaoilaSpawnPoint.position.x, gaoilaSpawnPoint.position.y, 10 ), Quaternion.identity);
			}
		}
	}
	
	/*void OnCollisionExit2D(Collision2D collision) {
		if (IsPressed) {
			IsPressed = false;
		}
	}*/
}
