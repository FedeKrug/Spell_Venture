using UnityEngine;

namespace Game.Objects
{
	public  class Portal : MonoBehaviour, Interactable
	{
		public void Interact()
		{
			Debug.Log("Player has used the portal");
			//TODO: Make abstract class for interactable objects with a method named "Interact();"
		}
	}
}