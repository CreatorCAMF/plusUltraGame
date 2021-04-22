using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayName : MonoBehaviour {

	//public string name;
	//public GameObject InputField;
	public GameObject textDisplay;
	
	void Start(){
		textDisplay.GetComponent<Text>().text = CharacterName.character_name;
	}

	public void dispName()
	{
		//name = InputField.GetComponent<Text>().text;
	}
}
