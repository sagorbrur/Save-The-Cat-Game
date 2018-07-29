using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;


public class MovePlayer : MonoBehaviour {

	float directionX;
	Rigidbody2D rb;
	public float xMin,xMax;

	public GameObject GameOverText,restartButton;//ExtraLine
	//public Sprite boundary;
	public GameObject boundary;



	// Use this for initialization
	void Start () {
	
		GameOverText.SetActive (false);//Extraliine
		restartButton.SetActive (false);//Extraline
		//boundary = GetComponent<Sprite> ();
		boundary.SetActive (true);
	


		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		directionX = CrossPlatformInputManager.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (directionX * 10, 0);
		rb.position=new Vector2(Mathf.Clamp(rb.position.x,xMin,xMax),0.0f); 

	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals ("bomb")) {
			GameOverText.SetActive(true);
			restartButton.SetActive(true);
			gameObject.SetActive(false);
			//Destroy(boundary);
			boundary.SetActive(false);
			CountPoints.score = 0;
			//CountPoints.score = CountPoints.score;



		}
	}




}
