using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class Tiling : MonoBehaviour {

	public int CalculationOffsetX = 2;

	public bool HasLeftTile = false;
	public bool HasRightTile = false;
	public bool flipNewTitle = true;

	private Camera _cam;
	private SpriteRenderer _spriteRenderer;

	void Awake()
	{
		_cam = Camera.main;
	}
	// Use this for initialization
	void Start () {
		_spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(!HasLeftTile || !HasRightTile){

			//float left = _cam.ScreenToWorldPoint(new Vector3(-Screen.width/2.0f,0,0)).x;

			float screenRatio = (float)Screen.width/(float)Screen.height;

			float cameraRightEdge = _cam.transform.position.x + _cam.orthographicSize * screenRatio;

			float cameraLefttEdge = _cam.transform.position.x - _cam.orthographicSize * screenRatio;

			float spriteRightEdge = transform.position.x + Mathf.Abs( transform.localScale.x)* _spriteRenderer.sprite.bounds.size.x/2f;
			float spriteLeftEdge = transform.position.x - Mathf.Abs( transform.localScale.x)*_spriteRenderer.sprite.bounds.size.x/2f;

			if(!HasRightTile && spriteRightEdge < cameraRightEdge+CalculationOffsetX)
			{
				AddTile(false);
			}
			if(!HasLeftTile && spriteLeftEdge > cameraLefttEdge - CalculationOffsetX)
			{
				AddTile(true);			
			}


		}
	}

	void AddTile(bool isLeftTile)
	{
		Vector3 newTilePos = transform.position;
		newTilePos.x -= isLeftTile? Mathf.Abs( transform.localScale.x)*_spriteRenderer.sprite.bounds.size.x: -Mathf.Abs( transform.localScale.x)*_spriteRenderer.sprite.bounds.size.x;

		Transform cloneTitle = Instantiate (transform, newTilePos, transform.rotation) as Transform;
		//SpriteRenderer renderer = cloneTitle.GetComponent<SpriteRenderer>();
		//cloneTitle.GetComponent<SpriteRenderer>().color = new Color(renderer.color.r, renderer.color.g, renderer.color.b, 255f);
		
		
		cloneTitle.parent = transform.parent;
		if (flipNewTitle) {
			var scale = transform.localScale;
			scale.x *= -1;
			cloneTitle.localScale = scale;
		}
		if (isLeftTile) {
			HasLeftTile = true;
			cloneTitle.GetComponent<Tiling>().HasRightTile = true;
		}
		else{
			HasRightTile = true;
			cloneTitle.GetComponent<Tiling>().HasLeftTile = true;
		}

	}
}
