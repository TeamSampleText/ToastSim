using UnityEngine;
using System.Collections;



public class main : MonoBehaviour {
	int toastwait = 3;

	// Use this for initialization
	void Start () {
		print ("Starting: " + Time.time);
		StartCoroutine(timer());

	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator  timer() {


		for (int toast = 0; toast < 5; toast++) {
			print ("Toast: " + toast);
			print ("Calum a is a huge cock");

			yield return new WaitForSeconds(toastwait);
		}

	}


}
