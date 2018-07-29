using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {

	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ExitButton()
	{
		Application.LoadLevel("MainMenu");
		
	}
	public void QuitGame()
	{
		Application.Quit ();
	}
}
