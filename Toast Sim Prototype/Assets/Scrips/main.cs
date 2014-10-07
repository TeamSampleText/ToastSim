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


		for (int timer = 0; timer < 1; timer++) {
			print ("Timer: " + timer);
		

			yield return new WaitForSeconds(toastwait);
		}

	}


}
