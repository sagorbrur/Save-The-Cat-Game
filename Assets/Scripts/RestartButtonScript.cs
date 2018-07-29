using UnityEngine;
using System.Collections;

public class RestartButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Application.LoadLevel ("TouchMoveScene");
	
	}
	public void restartScene () {

		Application.LoadLevel ("TouchMoveScene");
		//CountPoints.score = 0;

		
	}


}
