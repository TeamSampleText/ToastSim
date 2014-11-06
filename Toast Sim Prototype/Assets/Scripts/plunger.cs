using UnityEngine;
using System.Collections;

public class plunger : MonoBehaviour {

	public GameObject plunger_obj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Toaster.toasterclicked == true) {
			plunger_down();		
		}
	}
	void plunger_down(){
	
		Vector3 plungerDown = new Vector3(0,0,-0.1f); 
		if (transform.position.y > 0.34) {
			transform.Translate (plungerDown * Time.deltaTime);
		}
	}
}
