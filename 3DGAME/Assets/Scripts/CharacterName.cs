using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterName : MonoBehaviour {

	public string charName;
	public static string character_name;
	public GameObject InputField;
	//public GameObject textDisplay;
	
	public void StoreName()
	{
		charName = InputField.GetComponent<Text>().text;
		//textDisplay.GetComponent<Text>().text = charName;
		character_name = charName;
	}
}
