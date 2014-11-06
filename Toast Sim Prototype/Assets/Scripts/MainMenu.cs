using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GUIText title_txt;

	private int playBtnWidth = 200 ;
	private int playBtnHeight = 120 ;
	private int playBtnWidthSpacer = 220 ;
	private int playBtnHeightSpacer = 200;

	private int quitBtnWidth = 200;
	private int quitBtnHeight = 50 ;
	private int quitBtnWidthSpacer = 220;
	private int quitBtnHeightSpacer = 50;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		title_txt.text = "Toast Simulator\n2015\n420 MLG Edition";

		Rect PlayButton = new Rect (Screen.width - (playBtnWidth + playBtnWidthSpacer), Screen.height - (playBtnHeight + playBtnHeightSpacer), playBtnWidth, playBtnHeight);
		Rect QuitButton = new Rect (Screen.width - (quitBtnWidth + quitBtnWidthSpacer), Screen.height - (quitBtnHeight + quitBtnHeightSpacer), quitBtnWidth, quitBtnHeight);

		if (GUI.Button (PlayButton, "PLAY GAME")) {
			print ("PLAY button clicked");
			Application.LoadLevel("toastsimproto1");
		}

		if (GUI.Button (QuitButton, "QUIT")) {
			Application.Quit ();
		}
		
	}
}
