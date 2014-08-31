using UnityEngine;
using System.Collections;

public class ButtonColiderBehaviour : ObjectsBehaviour {

	public float offsetCollider;

	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player") 
		{
			if (currentState() == GameStateBehaviour.STATES.Sad)
			{
				BoxCollider2D box = gameObject.GetComponent<BoxCollider2D>();
				box.size = new Vector2(box.size.x, box.size.y - offsetCollider);
			}
			else
			{
				BoxCollider2D box = gameObject.GetComponent<BoxCollider2D>();
				box.size = new Vector2(box.size.x, box.size.y + offsetCollider);
			}
		}

	}
}
