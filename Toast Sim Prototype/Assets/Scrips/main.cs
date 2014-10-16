using UnityEngine;
using System.Collections;



public class main : MonoBehaviour {
	public int score = 0;
	public Transform Toast;
	
	public GameObject Toaster_obj; 
	public GameObject toast_obj;
	private float toastX = 0;
	private float toastY = 0;
	private int toastwait = 1;
	private int timerToast = 0;
	private int testtime = 2 ;
	private bool toastMake = false;
	public  GUIText score_txt;
	// Use this for initialization
	void Start () {
		
		//print ("Starting: " + Time.time);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		StartCoroutine(timer());
		toastX = 0;
		toastY = 0.7f;
		
		if (Toast_object.toastClicked == true) {
			//	print (currentToast.transform.position.y);
		
				//if(toast_obj.transform.position.y>Toaster_obj.transform.localPosition.y+1)
				
				score+=3;
				

			
			Toast_object.toastClicked = false;
			score_txt.text = "Score: " + score ;
			//DestroyObject(toast_obj);
			
			
		}
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
			
			
			Instantiate(Toast, new Vector3(toastX,toastY), Quaternion.identity) ;
			//toast_obj.gameObject.tag = "Toast "+ toastCount;
			//print("Toast made " + Toast.tag);
			timerToast = 0;
			toastMake = false;
		}
		
	}
	
	
	void UpdateScore() {
		
	}
	
	
}




