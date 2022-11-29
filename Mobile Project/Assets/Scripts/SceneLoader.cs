using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
	public void OnExit()
	{
		Application.Quit();
	}
	public void OnChangeScene(string level)
	{
		SceneManager.LoadScene(level);
	}
	public void OnReloadScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void OnGoBack(GameObject objectToTurnOf)
	{
		objectToTurnOf.SetActive(false);
	}
	public void OnActiveScreen(GameObject objectToTurnOn)
	{
		objectToTurnOn.SetActive(true);
	}
}
