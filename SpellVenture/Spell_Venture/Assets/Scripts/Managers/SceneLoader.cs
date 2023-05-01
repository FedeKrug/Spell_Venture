
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Game.Managers
{
	public class SceneLoader : MonoBehaviour
	{
		public static SceneLoader instance;
		private void Awake()
		{
			if (instance == null)
			{
				instance = this;
			}
			else
			{
				Destroy(gameObject);
			}
		}

		public void ChangeScene(string newScene)
		{
			SceneManager.LoadScene(newScene);
		}
		public void ReloadScene()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		public void QuitGame()
		{
			Application.Quit();
			Debug.Log("Game exit");
		}
	}
}