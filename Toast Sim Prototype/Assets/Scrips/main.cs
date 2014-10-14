using UnityEngine;
using System.Collections;



public class main : MonoBehaviour {
	public static int score = 0;
	public Transform Toast;

	private int toastwait = 1;
	private int timerToast = 0;

	// Use this for initialization
	void Start () {

		//print ("Starting: " + Time.time);
	

	}
	
	// Update is called once per frame
	void Update () {
	
			StartCoroutine(timer());
				
	}

	IEnumerator  timer() {
		if(Toaster.toasterclicked == true){


		for (; timerToast < 10; timerToast++) {

			print ("Timer: " + timerToast);
		
			Toaster.toasterclicked = false;

			//Pop toast

			yield return new WaitForSeconds(toastwait);

				}
			Toaster.toasterclicked = false;
			Instantiate(Toast, new Vector3(0,0.7f,0), Quaternion.identity);
			print("Toast made");
			timerToast = 0;

			}

		}

	}





