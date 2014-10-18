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





		if (GUI.Button (new Rect (Screen.width - (backbtnWidth + backbtnSpacer),Screen.height - (backbtnHeight + backbtnSpacer), backbtnWidth, backbtnHeight), "Back")) {
			print ("Back button clicked");
			Application.LoadLevel("toastsimproto1");
		}

		if (GUI.Button (new Rect (columnOneBtnWidthSpacer, rowOneBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Silencer")) {
			print("Silencer button clicked.") ;

		}

		if (GUI.Button (new Rect (columnOneBtnWidthSpacer, rowTwoBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "ACOG Scope")) {
			print("ACOG Scope button clicked.") ;
			
		}

		if (GUI.Button (new Rect (columnOneBtnWidthSpacer, rowThreeBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Red Dot Sight")) {
			print("Red Dot Sight button clicked.") ;
			
		}

		if (GUI.Button (new Rect (columnOneBtnWidthSpacer, rowFourBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Extended Slots")) {
			print("Extended Slots button clicked.") ;
			
		}
		
		if (GUI.Button (new Rect (columnOneBtnWidthSpacer, rowFiveBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Hotter Element")) {
			print("Hotter Element button clicked.") ;
			
		}

		if (GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowOneBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Diamond Camo")) {
			print("Diamond Camo button clicked.") ;
			
		}
		
		if (GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowTwoBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "White Party Hat")) {
			print("White Party Hat button clicked.") ;
			
		}
		
		if (GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowThreeBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Powerful Spring")) {
			print("Powerful Spring button clicked.") ;
			
		}
		
		if (GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowFourBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Extra Toaster")) {
			print("Extra Toaster button clicked.") ;
			
		}
		
		if (GUI.Button (new Rect (columnTwoBtnWidthSpacer, rowFiveBtnHeightSpacer, upgradebtnWidth, upgradebtnHeight), "Flamethrower")) {
			print("Flamethrower button clicked.") ;
			
		}

	}
}
