using UnityEngine;
using System.Collections;

public class LinkScript : MonoBehaviour {

	public void FollowFacebook()
	{
		Application.OpenURL ("https://www.facebook.com/sagor.sarker.brur");

	}
	public void HelpButton()
	{
		Application.LoadLevel ("HelpScene");
	}
}
