using UnityEngine;
using System.Collections;


public class upgrademenu : MonoBehaviour
{
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

		if ((GUI.Button (new Rect (columnOneBtnWidthSpacer, rowOneBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Silencer")) && (main.score >= silencerCost)) {
			print("Silencer button clicked.") ;
			main.score -= silencerCost;

		}

		if ((GUI.Button (new Rect (columnOneBtnWidthSpacer, rowTwoBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "ACOG Scope")) && (main.score >= ACOGCost)) {
			print("ACOG Scope button clicked.") ;
			main.score -= ACOGCost ;
			
		}

		if ((GUI.Button (new Rect (columnOneBtnWidthSpacer, rowThreeBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Red Dot Sight")) && (main.score >= redDotSightCost)) {
			print("Red Dot Sight button clicked.") ;
			main.score -= redDotSightCost ;

		}

		if ((GUI.Button (new Rect (columnOneBtnWidthSpacer, rowFourBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Extended Slots")) && (main.score >= extendedSlotsCost)) {
			print("Extended Slots button clicked.") ;
			main.score -= extendedSlotsCost ;

		}
		
		if ((GUI.Button (new Rect (columnOneBtnWidthSpacer, rowFiveBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Hotter Element")) && (main.score >= hotterElementCost)) {
			print("Hotter Element button clicked.") ;
			main.score -= hotterElementCost;

		}

		if ((GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowOneBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Diamond Camo")) && (main.score >= diamondCamoCost)) {
			print("Diamond Camo button clicked.") ;
			main.score -= diamondCamoCost;

		}
		
		if ((GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowTwoBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "White Party Hat")) && (main.score >= whitePartyHatCost)) {
			print("White Party Hat button clicked.") ;
			main.score -= whitePartyHatCost;

		}
		
		if ((GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowThreeBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Powerful Spring")) && (main.score >= powerfulSpringCost)) {
			print("Powerful Spring button clicked.") ;
			main.score -= powerfulSpringCost;

		}
		
		if ((GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowFourBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Extra Toaster")) && (main.score >= extraToasterCost)) {
			print("Extra Toaster button clicked.") ;
			main.score -= extraToasterCost;

		}
		
		if ((GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowFiveBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Flamethrower")) && (main.score >= flamethrowerCost)) {
			print("Flamethrower button clicked.") ;
			main.score -= flamethrowerCost;

		}

	}
}
