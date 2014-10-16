using UnityEngine;
using System.Collections;

public class Toaster : MonoBehaviour
{
	public Transform Toast;
	public GameObject Toaster_obj;
	public static bool toasterclicked = false;


	public static int toastcount = 0;
	public static float ToasterX = 0;
	public static float ToasterY = 0;
	public float toasterHeight = 0;
		// Use this for initialization

		void Start ()
		{

		print ("Is toaster been clicked? " + toasterclicked);
		toasterHeight = Toaster_obj.renderer.bounds.y;
	
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

			//Instantiate(Toast, new Vector3(toastX,toastY,0), Quaternion.identity);
			//print("Toast made");
			//toasterclicked = false;
		

			                        }

		}
	void OnMouseDown()
	{
		toasterclicked = true;
		print ("Is toaster been clicked? " + toasterclicked);
	
	}
	
	
}
