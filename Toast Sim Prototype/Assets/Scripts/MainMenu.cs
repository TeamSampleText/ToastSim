using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GUIText title_txt;

	private int playBtnWidth = 200 ;
	private int playBtnHeight = 120 ;
	private int playBtnWidthSpacer = 220 ;
	//private int playBtnHeightSpacer = 300;

	// Use this for initialization
	void Start () {
		title_txt.text = "Toast Simulator\n2015\n420 MLG Edition";

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGui(){

		Rect PlayButton = new Rect (Screen.width - (playBtnWidth/* + playBtnWidthSpacer*/), Screen.height - (playBtnHeight /*+ playBtnHeightSpacer*/), playBtnWidth, playBtnHeight);
	

		if (GUI.Button (PlayButton, "PLAY GAME")) {
			print ("PLAY button clicked");
			Application.LoadLevel("toastsimproto1");
		}

		if ((GUI.Button (new Rect (2, 2, 2, 2), "Silencer \n 10 Toast")) && (main.score >= 2)) {
			print("Silencer button clicked.") ;
				
				
		}


	}
}
