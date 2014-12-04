using UnityEngine;
using System.Collections;

public class End : MonoBehaviour 
{
	
	public Texture backgroundTexture;
	public Texture Random1;
	public GUIStyle Random2;
	
	public float guiPlacementX1;
	public float guiPlacementX2;
	public float guiPlacementX3;
	public float guiPlacementX4;
	public float guiPlacementY1;
	public float guiPlacementY2;
	public float guiPlacementY3;
	public float guiPlacementY4;
	
	public bool showGUIOutline = true;
	
	void OnGUI()
	{
		//Display our background texture
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		//Displays our Buttons (With GUI outline)
		if (showGUIOutline) 
		{
			if (GUI.Button (new Rect (Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "Play Again?")) 
			{
				Application.LoadLevel("Level2"); 
			}
			
			if (GUI.Button (new Rect (Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .5f, Screen.height * .1f), "Main Menu")) 
			{
				Application.LoadLevel ("MainMenu");
			} 
		} 
		
		//Displays our Buttons (Without GUI outline)
		else 
		{
			if (GUI.Button (new Rect (Screen.width * guiPlacementX3, Screen.height * guiPlacementY3, Screen.width * .5f, Screen.height * .1f), Random1, "")) 
			{
				print ("clicked play game");
			}
			
			if (GUI.Button (new Rect (Screen.width * guiPlacementX4, Screen.height * guiPlacementY4, Screen.width * .5f, Screen.height * .1f), "", Random2)) 
			{
				print ("clicked options");
			}
		}
		
		
		
	}
}
