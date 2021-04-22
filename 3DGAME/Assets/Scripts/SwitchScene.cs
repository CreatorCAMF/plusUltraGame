using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	public static string mode;

	public void singleP()
	{
		mode = "solo";
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void multiP()
	{
		mode = "multi";
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
