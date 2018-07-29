using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals ("bomb")) {
			CountPoints.score +=5; 
			//GameObject.SetActive(false);
			
			
		}

	}
}
