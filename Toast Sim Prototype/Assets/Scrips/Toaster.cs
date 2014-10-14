using UnityEngine;
using System.Collections;

public class Toaster : MonoBehaviour
{
	public Transform Toast;
	private float toastX = 1;
	private float toastY = 2;

		bool toasterclicked = false;
	
		// Use this for initialization
		void Start ()
		{

		print ("Is toaster been clicked? " + toasterclicked);
	
		}
	
		// Update is called once per frame
		void Update ()
		{
		if (Input.GetMouseButtonUp (0)) {
						toasterclicked = false;
						print ("Is toaster been clicked? " + toasterclicked);
				}
		

		if (toasterclicked == true) {
		
			Instantiate(Toast, new Vector3(toastX,toastY,0), Quaternion.identity);
			print("Toast made");
			toasterclicked = false;

			                        }

		}
	void OnMouseDown()
	{
		toasterclicked = true;
		print ("Is toaster been clicked? " + toasterclicked);
	
	}
	
	
}
