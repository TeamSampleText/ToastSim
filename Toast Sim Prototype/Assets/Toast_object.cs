using UnityEngine;
using System.Collections;

public class Toast_object : MonoBehaviour {

	int score = 0;
	public int toast = 0;
	public float timeIncrease = 1;
	public bool timeElapsed = false;
	int toastseconds = 5 ;

	void OnMouseDown() {

		score++;
		print ("Score: " + score);
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}




}
