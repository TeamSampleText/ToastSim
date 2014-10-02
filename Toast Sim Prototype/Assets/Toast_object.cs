using UnityEngine;
using System.Collections;

public class Toast_object : MonoBehaviour {

	int score = 0;


	void OnMouseDown() {

		score++;
		print ("Score: " +score);


	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Score_txt= score;
	}
}
