using UnityEngine;
using System.Collections;


public class Toast_object : MonoBehaviour {
	public GUIText score_txt;
	public GameObject toast;
	

	void OnMouseDown() {
		main.score ++;
		UpdateScore ();
		print ("Current Score: " + main.score);
		Destroy (gameObject);
	//	DestroyImmediate (toast, true);

	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//score_txt.text = "Score " + score;
	}

	void UpdateScore() {
		score_txt.text = "Score " + main.score;
	}


}
