
using Game.Interfaces;

using System.Collections.Generic;

using UnityEngine;


namespace Game.Player
{
	public class PlayerInteractor : MonoBehaviour
	{
		[SerializeField] private KeyCode _interactionKey;
		[SerializeField] private List<Interactable> _interactableList = new List<Interactable>();
		[SerializeField] private GameObject _interactionText;

		private void Update()
		{
			if (_interactableList.Count <= 0) return;

			if (Input.GetKeyDown(_interactionKey))
			{
				_interactableList[_interactableList.Count - 1]?.Interact();
				_interactionText.SetActive(false);	
			}

		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.GetComponent<Interactable>() != null)
			{
				var interactable = collision.GetComponent<Interactable>();
				if (interactable == null) return;
				_interactableList.Add(interactable);
				_interactionText.SetActive(true);
			}
			
		}

		private void OnTriggerExit2D(Collider2D collision)
		{
			if (collision.GetComponent<Interactable>() != null)
			{
				var interactable = collision.GetComponent<Interactable>();
				if (interactable == null) return;
				_interactableList.Remove(interactable);
				_interactionText.SetActive(false);
			}
		}
	}



}
