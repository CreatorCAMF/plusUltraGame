using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {

	public void quitGameFromMenu()
	{
		//UnityEditor.EditorApplication.isPlaying = false;
		Application.Quit();
	}
}
