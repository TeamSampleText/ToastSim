// What we need to do:
//
// 1. Score
/////////////////// 1.1 add to score
// 1.2 location dependent score
/////////////////// 1.3 remove score after purchases 
/////////////////// 1.4 Make score not reset when move from main screen to upgrades
//
// 2. Need toaster Model 
// 2.1 Murder Harry
// 
// 3. Phyics !
// 3.1 Toast to pop when toasted 
// 3.2 Toaster Plunger to go down when toasting
// 
/////////////////// 4. Basic upgrades / upgrade screen
// 4.1 Make upgrades affect the game
// 
// 5.Get backgrounds for images
// 
// 6. Proper UI
// 6.1 Change pointer when over toast?
// 6.2 Tell the player whats going on ie timer, ect
//  
// 7. Materials 
// 
// 8. Sounds
//
// 9. Start up of game
// 9.1 Splash screen
// 9.2 start screen
// 9.3 Name entering ? 
// 
// 10. BREAD !!!!!!!
// 10.1 move bread to le toaster 
//



using UnityEngine;
using System.Collections;



public class main : MonoBehaviour {
	public static int score  = 000000;
	public Transform Toast;
	
	public GameObject Toaster_obj; 
	public GameObject toast_obj;
	private float toastX = 0;
	private float toastZ = 0;
	private float toastY = 0;
	private int toastwait = 1;
	private int timerToast = 0;
	private int testtime = 2 ;
	private bool toastMake = false;
	public  GUIText score_txt;
	private int toastCount = 0;


	private int totalToast = 0 ;
	// Use this for initialization
	void Start () {
		
		//print ("Starting: " + Time.time);
		
		score_txt.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {

		TestremoveScore ();
		TestAddScore ();
		StartCoroutine(timer());
		toastX = 0;
		toastY = 1.1f;
		toastZ = 0;

		
		if (Toast_object.toastClicked == true) {
			//	print (currentToast.transform.position.y);

			if (tag.Contains("toast") ){
				//Do toasty shit
				if(gameObject.transform.position.y <= 0.4f){
					score+=3;
					totalToast++;
				}
			}else{
				score++;
				totalToast++;
			}

			
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
			toastCount++;
			GameObject newToast;
			newToast = Instantiate(Toast, new Vector3(toastX,toastY,toastZ-0.2f), Quaternion.identity) as GameObject;
			//newToast.tag = "toast" + toastCount ;
			
			GameObject RandomTestToaster;
//			RandomTestToaster = GameObject.FindGameObjectWithTag("toaster");
			
			
			//PROTIP: Accessing variables in other scripts
			//First, create a variable to old script e.g
//			Toast_object script = Toast_object.GetComponent<Toast_object>();
	//			script.
			
			//toast_obj.gameObject.tag = "Toast "+ toastCount;
			//print("Toast made " + Toast.tag);
			timerToast = 0;
			toastMake = false;
		}
		
	}

	void TestremoveScore()
	{
		if (Input.GetKeyDown(KeyCode.Return)){
			score--;		
			score_txt.text = "Score: " + score ;
		}
	}
	void TestAddScore()
	{
		if (Input.GetKeyDown(KeyCode.Space)){
			score++;		
			score_txt.text = "Score: " + score ;
		}
	}
	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;
		const int buttonSpacer = 10;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect((Screen.width - (buttonWidth + buttonSpacer)),buttonSpacer, buttonWidth ,buttonHeight);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,"Upgrades"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("upgrademenu");
		}



	}
}







