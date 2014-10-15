using UnityEngine;
using System.Collections;



public class main : MonoBehaviour {
	public static int score = 0;
	public Transform Toast;
	public GameObject Toaster_obj; 
	public GameObject toast_obj;
	private float toastX = 0;
	private float toastY = 0;
	private int toastwait = 1;
	private int timerToast = 0;
	private int testtime = 5 ;
	private bool toastMake = false;
	// Use this for initialization
	void Start () {

		//print ("Starting: " + Time.time);
	

	}
	
	// Update is called once per frame
	void Update () {
	
		StartCoroutine(timer());
		toastX = 0;
		toastY = 0.7f;


	}

	IEnumerator  timer() {

		if(toastMake == false && Toaster.toasterclicked == true){


		for (; timerToast < testtime; timerToast++) {

			toastMake = true;

			print ("Timer: " + timerToast);
		
			Toaster.toasterclicked = false;

			//Pop toast

			yield return new WaitForSeconds(toastwait);

				}

			print("X pos: "+Toaster_obj.transform.position.x + "y pos: "+ Toaster.ToasterY);
			Toaster.toasterclicked = false;

			
			Instantiate(Toast, new Vector3(toastX,toastY), Quaternion.identity);
			//toast_obj.gameObject.tag = "Toast "+ toastCount;
			//print("Toast made " + Toast.tag);
			timerToast = 0;
			toastMake = false;
			}

		}

	}





