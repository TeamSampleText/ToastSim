using UnityEngine;
using System.Collections;

public class Toaster : MonoBehaviour
{
	public Transform Toast;
	public Transform Toaster_obj;

	private int toastcount = 0;
	private float toastX = 0;
	private float toastY = 0.7f;
	private GameObject instantiatedToast;

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
					//	toasterclicked = false;
						print ("Is toaster been clicked? " + toasterclicked);
				}
		

		if (toasterclicked == true) {
			toastcount++; 

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
