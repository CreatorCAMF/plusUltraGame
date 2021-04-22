using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayName2 : MonoBehaviour {

	//public string name;
	//public GameObject InputField;
	public GameObject textDisplay;
	
	void Start(){
		textDisplay.GetComponent<Text>().text = CharacterName.character_name+"_2";
	}

	public void dispName()
	{
		//name = InputField.GetComponent<Text>().text;
	}
}