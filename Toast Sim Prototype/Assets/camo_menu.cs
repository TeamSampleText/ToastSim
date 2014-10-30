using UnityEngine;
using System.Collections;

public class camo_menu : MonoBehaviour {

	
	private static bool isSilencerAvailable = true;
	private static bool isACOGAvailable = true;
	private static bool isRedDotSightAvailable = true;
	private static bool isExtendedSlotsAvailable = true;
	private static bool isHotterElementAvailable = true;
	private static bool isDiamondCamoAvailable = true;
	private static bool isWhitePartyHatAvailable = true;
	private static bool isPowerfulSpringAvailable = true;
	private static bool isExtraToasterAvailable = true;
	private static bool isFlamethrowerAvailable = true;
	
	public static bool silencerEquipped = false;
	public static bool ACOGEquipped = false;
	public static bool redDotSightEquipped = false;
	public static bool extendedSlotsEquipped = false;
	public static bool hotterElementEquipped = false;
	public static bool diamondCamoEquipped = false;
	public static bool whitePartyHatEquipped = false;
	public static bool powerfulSpringEquipped = false;
	public static bool extraToasterEquipped = false;
	public static bool flamethrowerEquipped = false;
	
	
	void OnGUI()
	{
		const int backbtnWidth = 100 ;
		const int backbtnHeight = 20 ;
		const int backbtnSpacer = 10 ;
		
		const int upgradebtnWidth = 120 ;
		const int upgradebtnHeight = 60 ;
		
		const int columnOneBtnWidthSpacer = 100 ;
		const int columnTwoBtnWidthSpacer = 230;
		
		const int rowOneBtnHeightSpacer = 60 ;
		const int rowTwoBtnHeightSpacer = 130;
		const int rowThreeBtnHeightSpacer = 200;
		const int rowFourBtnHeightSpacer = 270;
		const int rowFiveBtnHeightSpacer = 340;
		
		const int silencerCost = 10;
		const int ACOGCost = 25;
		const int redDotSightCost = 50;
		const int extendedSlotsCost = 100;
		const int hotterElementCost = 200;
		const int diamondCamoCost = 500;
		const int whitePartyHatCost = 1000;
		const int powerfulSpringCost = 2500;
		const int extraToasterCost = 7500;
		const int flamethrowerCost = 20000;
		
		
		if (GUI.Button (new Rect (Screen.width - (backbtnWidth + backbtnSpacer),Screen.height - (backbtnHeight + backbtnSpacer), backbtnWidth, backbtnHeight), "Back")) {
			print ("Back button clicked");
			Application.LoadLevel("toastsimproto1");
		}
		
		if ((GUI.Button (new Rect (columnOneBtnWidthSpacer, rowOneBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Silencer \n 10 Toast")) && (main.score >= silencerCost) && (isSilencerAvailable == true)) {
			print("Silencer button clicked.") ;
			main.score -= silencerCost;
			silencerEquipped = true ;
			
			isSilencerAvailable = false ;
			
		}
		
		if ((GUI.Button (new Rect (columnOneBtnWidthSpacer, rowTwoBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "ACOG Scope \n 25 Toast")) && (main.score >= ACOGCost) && (isACOGAvailable == true)) {
			print("ACOG Scope button clicked.") ;
			main.score -= ACOGCost ;
			ACOGEquipped = true; 
			
			isACOGAvailable = false ;
			
		}
		
		if ((GUI.Button (new Rect (columnOneBtnWidthSpacer, rowThreeBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Red Dot Sight \n 50 Toast")) && (main.score >= redDotSightCost) && (isRedDotSightAvailable == true)) {
			print("Red Dot Sight button clicked.") ;
			main.score -= redDotSightCost ;
			redDotSightEquipped = true ;
			
			isRedDotSightAvailable = false ;
		}
		
		if ((GUI.Button (new Rect (columnOneBtnWidthSpacer, rowFourBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Extended Slots \n 100 Toast")) && (main.score >= extendedSlotsCost) && (isExtendedSlotsAvailable == true)) {
			print("Extended Slots button clicked.") ;
			main.score -= extendedSlotsCost ;
			extendedSlotsEquipped = true ;
			
			isExtendedSlotsAvailable = false ;
			
		}
		
		if ((GUI.Button (new Rect (columnOneBtnWidthSpacer, rowFiveBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Hotter Element \n 200 Toast")) && (main.score >= hotterElementCost) && (isHotterElementAvailable == true)) {
			print("Hotter Element button clicked.") ;
			main.score -= hotterElementCost;
			hotterElementEquipped = true ;
			
			isHotterElementAvailable = false ;
			
		}
		
		if ((GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowOneBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Diamond Camo \n 500 Toast")) && (main.score >= diamondCamoCost) && (isDiamondCamoAvailable == true)) {
			print("Diamond Camo button clicked.") ;
			main.score -= diamondCamoCost;
			diamondCamoEquipped = true;
			
			isDiamondCamoAvailable = false ;
			
		}
		
		if ((GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowTwoBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "White Party Hat \n 1'000 Toast")) && (main.score >= whitePartyHatCost) && (isWhitePartyHatAvailable == true)) {
			print("White Party Hat button clicked.") ;
			main.score -= whitePartyHatCost;
			whitePartyHatEquipped = true ;
			
			isWhitePartyHatAvailable = false ;
			
		}
		
		if ((GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowThreeBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Powerful Spring \n 2'500 Toast")) && (main.score >= powerfulSpringCost) && (isPowerfulSpringAvailable == true)) {
			print("Powerful Spring button clicked.") ;
			main.score -= powerfulSpringCost;
			powerfulSpringEquipped = true ;
			
			isPowerfulSpringAvailable = false ;
		}
		
		if ((GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowFourBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Extra Toaster \n 7'500 Toast")) && (main.score >= extraToasterCost) && (isExtraToasterAvailable = false)) {
			print("Extra Toaster button clicked.") ;
			main.score -= extraToasterCost;
			extraToasterEquipped = true ;
			
			isExtraToasterAvailable = false ;
			
		}
		
		if ((GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowFiveBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Flamethrower \n 25'000 Toast")) && (main.score >= flamethrowerCost) && (isFlamethrowerAvailable == true)) {
			print("Flamethrower button clicked.") ;
			main.score -= flamethrowerCost;
			flamethrowerEquipped = true ;
			
			isFlamethrowerAvailable = false ;
		}
		
	}
}
