using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AudioControl : MonoBehaviour {

	private AudioSource audioSource;
	
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}
	


	public void muteAudio()
	{
		AudioListener.pause = !AudioListener.pause;

	}
}
