using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private static GameManager instance;
	
	private GameManager() {}
	
	public static GameManager Instance
	{
		get 
		{
			if (instance == null)
			{
				instance = new GameManager();
			}
			return instance;
		}
	}
	
	public GameObject CurrentPlayer;
	public GameObject LatestCheckPoint;
	public GameObject PlayerPrefab;

	public void Respaw()
	{
		CurrentPlayer =  Instantiate (PlayerPrefab, LatestCheckPoint.transform.position, Quaternion.identity) as GameObject;
		var camera = GameObject.FindGameObjectWithTag("MainCamera");
		if (camera)
			camera.GetComponent<Camera2DFollow>().target = CurrentPlayer.transform;
		CurrentPlayer.GetComponent<SpriteRenderer> ().sortingOrder = 1;

		foreach(var obj in GameObject.FindGameObjectsWithTag("Respawn"))
		{
			var respawObj = obj.GetComponent<Respawnable>();
			if(respawObj){
				respawObj.Respaw();
			}
		}
	}

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
