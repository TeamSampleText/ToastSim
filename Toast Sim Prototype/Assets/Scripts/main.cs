// What we need to do:
//
// 1. Score
/////////////////// 1.1 add to score
// 1.2 location dependent score
/////////////////// 1.3 remove score after purchases 
/////////////////// 1.4 Make score not reset when move from main screen to upgrades
//
//////////////////////////// 2. Need toaster Model 
// 2.1 Murder Harry
// 
// 3. Phyics !
// 3.1 Toast to pop when toasted 
// 3.2 Toaster Plunger to go down when toasting
// 
/////////////////// 4. Basic upgrades / upgrade screen
// :( 4.1 Make upgrades affect the game
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
	public static int score  = 0;
	public Transform Toast;
	
	public GameObject Toaster_obj; 
	public GameObject toast_obj;
	private float toastX = 0;
	private float toastZ = 0;
	private float toastY = 0;
	private int maxToastingTime = 2;
	private int startToastingTime = 0;
	private int testToastingTime = 2 ;
	private bool toastMake = false;
	public  GUIText score_txt;
	private int toastCount = 0;
	
	private int totalToast = 0 ;

	bool silencerCheck = upgrademenu.silencerEquipped ;
	bool ACOGCheck = upgrademenu.ACOGEquipped;
	bool redDotSightCheck = upgrademenu.redDotSightEquipped;
	bool extendedSlotsCheck = upgrademenu.extendedSlotsEquipped;
	bool hotterElementCheck = upgrademenu.hotterElementEquipped;
	bool diamondCamoCheck = upgrademenu.diamondCamoEquipped;
	bool whitePartyHatCheck = upgrademenu.whitePartyHatEquipped;
	bool powerfulSpringCheck = upgrademenu.powerfulSpringEquipped;
	bool extraToasterCheck = upgrademenu.extraToasterEquipped;
	bool flamethrowerCheck = upgrademenu.flamethrowerEquipped;

	private bool stopSilencerSpam = false ;

	static public bool toastPop = false;

	private const int upgradeHeightSpacer = 300;
	private const int upgradeBoxWidth = 200;
	private const int upgradeBoxHeight = 300;
	private const int Spacer = 10;


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
		toastZ = -0.2f;

		
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

		if (toastPop == true) {
			
			toastPop = false;
		}
	}
	
	IEnumerator  timer() {

		if((silencerCheck == true)&&(stopSilencerSpam == false)){
			maxToastingTime /= 2 ;
			stopSilencerSpam = true ;
		}
		
		if(toastMake == false && Toaster.toasterclicked == true){
			GameObject newToast;
			newToast = Instantiate(Toast, new Vector3(toastX,toastY,toastZ), Quaternion.identity) as GameObject;
			for (startToastingTime = 0; startToastingTime < maxToastingTime; startToastingTime++) {
				
				toastMake = true;
				
				print ("Timer: " + startToastingTime);
				
				Toaster.toasterclicked = false;

				yield return new WaitForSeconds(1);
				
				//Pop toast

			}

			toastPop = true;

	
			Toaster.toasterclicked = false;
			toastCount++;


		
			GameObject RandomTestToaster;
//			RandomTestToaster = GameObject.FindGameObjectWithTag("toaster");
			
			
			//PROTIP: Accessing variables in other scripts
			//First, create a variable to old script e.g
//			Toast_object script = Toast_object.GetComponent<Toast_object>();
	//			script.
		
			//toast_obj.gameObject.tag = "Toast "+ toastCount;
			//print("Toast made " + Toast.tag);
			startToastingTime = 0;
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



		//upgrademenu silencerCheck = upgrademenu.GetComponent<upgrademenu>();
		//if(silencerCheck.GetComponent.
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect((Screen.width - (buttonWidth + Spacer)), Spacer, buttonWidth ,buttonHeight);
		GUI.Label (new Rect (Spacer,upgradeHeightSpacer,upgradeBoxWidth,upgradeBoxHeight), "<color=#000000ff>Upgrades Purchased:</color>");

		if (silencerCheck == true) {
			GUI.Label (new Rect (Spacer, upgradeHeightSpacer, upgradeBoxWidth, upgradeBoxHeight), "\n<color=#000000ff>Silencer</color>");
		}

		if (ACOGCheck == true) {
			GUI.Label (new Rect (Spacer, upgradeHeightSpacer, upgradeBoxWidth, upgradeBoxHeight), "\n\n<color=#000000ff>ACOG Scope</color>");
		}

		if (redDotSightCheck == true) {
			GUI.Label (new Rect (Spacer, upgradeHeightSpacer, upgradeBoxWidth, upgradeBoxHeight), "\n\n\n<color=#000000ff>Red Dot Sight</color>");
		}

		if (extendedSlotsCheck == true) {
			GUI.Label (new Rect (Spacer, upgradeHeightSpacer, upgradeBoxWidth, upgradeBoxHeight), "\n\n\n\n<color=#000000ff>Extended Slots</color>");
		}

		if (hotterElementCheck == true) {
			GUI.Label (new Rect (Spacer, upgradeHeightSpacer, upgradeBoxWidth, upgradeBoxHeight), "\n\n\n\n\n<color=#000000ff>Hotter Element</color>");
		}

		if (diamondCamoCheck == true) {
			GUI.Label (new Rect (Spacer, upgradeHeightSpacer, upgradeBoxWidth, upgradeBoxHeight), "\n\n\n\n\n\n<color=#000000ff>Diamond Camo</color>");
		}

		if (whitePartyHatCheck == true) {
			GUI.Label (new Rect (Spacer, upgradeHeightSpacer, upgradeBoxWidth, upgradeBoxHeight), "\n\n\n\n\n\n\n<color=#000000ff>White Party Hat</color>");
		}

		if (powerfulSpringCheck == true) {
			GUI.Label (new Rect (Spacer, upgradeHeightSpacer, upgradeBoxWidth, upgradeBoxHeight), "\n\n\n\n\n\n\n\n<color=#000000ff>Powerful Spring</color>");
		}
		
		if (extraToasterCheck == true) {
			GUI.Label (new Rect (Spacer, upgradeHeightSpacer, upgradeBoxWidth, upgradeBoxHeight), "\n\n\n\n\n\n\n\n\n<color=#000000ff>Extra Toaster</color>");
		}
		
		if (flamethrowerCheck == true) {
			GUI.Label (new Rect (Spacer, upgradeHeightSpacer, upgradeBoxWidth, upgradeBoxHeight), "\n\n\n\n\n\n\n\n\n\n<color=#000000ff>Flamethrower</color>");
		}


		// Draw a button to start the game
		if(GUI.Button(buttonRect,"Upgrades"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("upgrademenu");
		}


	
	}

}