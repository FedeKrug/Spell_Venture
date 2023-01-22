using UnityEngine;
using UnityEngine.SceneManagement;
namespace Game.Objects
{
	public  class Portal : MonoBehaviour, Interactable
	{
		[SerializeField] private string _levelToGo;
		public void Interact()
		{
			Debug.Log("Player has used the portal");
			//TODO: Make abstract class for interactable objects with a method named "Interact();"
			SceneManager.LoadScene(_levelToGo);
		}

	}
}