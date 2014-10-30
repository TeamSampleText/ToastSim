using UnityEngine;
using System.Collections;


public class Toast_object : MonoBehaviour {
	
	public GameObject toast;
	public static bool toastClicked = false;
	public static Vector3 toastVelocity ;

	public float XForce = 0;
	public float YForce = 0;
	public float ZForce = 0;

	void OnMouseDown() {
		toastClicked = true;
		Destroy (gameObject);
		
	}
	
	// Use this for initialization
	void Start () {

		XForce = Random.Range (-25, 25);
		YForce = Random.Range (640, 850);
		ZForce = Random.Range (-25, 25);

	}
	
	void Update(){

		toastVelocity = getVelocity ();

	}

	void FixedUpdate () {
		if (main.toastPop) {
			print(main.toastPop);
			rigidbody.AddForce (XForce, YForce, ZForce);
			
		}


	}

	Vector3 getVelocity(){

		Rigidbody toastSpeed = GetComponent<Rigidbody>();
		Vector3 toastVelocity = toastSpeed.velocity;
	
		return toastVelocity;
	}

	
}
