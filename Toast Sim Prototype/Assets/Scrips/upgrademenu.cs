using UnityEngine;
using System.Collections;


public class upgrademenu : MonoBehaviour
{
	void OnGUI()
	{


		if (GUI.Button (new Rect (Screen.width - 110,Screen.height - 30, 100, 20), "Back")) {
			//print ("Back button clicked");
			Application.LoadLevel("toastsimproto1");
		}
	}
}
