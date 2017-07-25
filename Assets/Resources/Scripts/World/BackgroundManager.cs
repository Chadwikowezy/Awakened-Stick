using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour 
{
	public SpriteRenderer backgroundSpriteRenderer;
	public Sprite[] backgroundSprites;

	void Start () 
	{
		backgroundSpriteRenderer.sprite = backgroundSprites [Random.Range (0, backgroundSprites.Length)];

	}

}
