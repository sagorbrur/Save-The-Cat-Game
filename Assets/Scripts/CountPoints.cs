using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountPoints : MonoBehaviour {


	public static int score = 0;
	Text scoreText;

	// Use this for initialization
	void Start () {
		scoreText = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + score;
	}


}
