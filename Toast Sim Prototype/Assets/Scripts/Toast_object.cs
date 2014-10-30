using UnityEngine;
using System.Collections;


public class Toast_object : MonoBehaviour {
	
	public GameObject toast;
	public static bool toastClicked = false;


	public float XForce = 0;
	public float YForce = 0;
	public float ZForce = 0;

	void OnMouseDown() {
		toastClicked = true;
		Destroy (gameObject);
		
	}
	
	// Use this for initialization
	void Start () {



	}
	
	void Update(){
	
	

	}

	void FixedUpdate () {
		if (main.toastPop) {
			print(main.toastPop);
			rigidbody.AddForce (XForce, YForce, ZForce);
			
		}


	}

	
}
