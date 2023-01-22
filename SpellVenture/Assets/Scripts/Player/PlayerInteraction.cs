using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Objects;


namespace Game.Player
{
	public class PlayerInteraction : MonoBehaviour
	{

		[SerializeField] private GameObject _keyToInteractUI;
		[SerializeField] private List<Interactable> _interactableList = new List<Interactable>();


		private void OnTriggerEnter2D(Collider2D collision)
		{
			var interactable = collision.GetComponent<Interactable>();
			if (interactable != null)
			{
				Debug.Log("This object is interactable");
				_interactableList.Add(interactable);
			}
		}
		private void OnTriggerExit2D(Collider2D collision)
		{
			var interactable = collision.GetComponent<Interactable>();
			if (interactable != null)
			{
				Debug.Log("There are no interactions");
				_interactableList.Remove(interactable);
			}
		}

		public void OnInteract()
		{
			Debug.Log("Player is interacting");

			if (_interactableList.Count > 0)
			{
				_interactableList[_interactableList.Count - 1]?.Interact();
				Debug.Log(_interactableList[_interactableList.Count - 1]);
			}
		}
	}

}
