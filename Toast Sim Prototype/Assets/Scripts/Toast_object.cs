using UnityEngine;
using System.Collections;


public class Toast_object : MonoBehaviour {
	
	public GameObject toast;
	public static bool toastClicked = false;




	void OnMouseDown() {
		toastClicked = true;
		Destroy (gameObject);
		
	}
	
	// Use this for initialization
	void Start () {

		


	}
	
	void Update(){
	
	//	if (main.toastPop == true) {
	//		rigidbody.AddForce (XForce, YForce, ZForce);
	//		main.toastPop = false;
	//	}


	}

	void FixedUpdate () {
	

	}

	
}
