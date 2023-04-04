
using Game.Interfaces;

using UnityEngine;


namespace Game.Player
{
	public class PlayerInteractor : MonoBehaviour
	{
		[SerializeField] private KeyCode _interactionKey;
		[SerializeField] private bool _canInteract;

		private void Update()
		{
			
		}
		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.GetComponent<Interactable>() != null)
			{
				//_canInteract = true;
				//if (Input.GetKeyDown(_interactionKey))
				//{
					collision.GetComponent<Interactable>().Interact();
				//}
			}
		}

		private void OnTriggerExit2D(Collider2D collision)
		{
			if (collision.GetComponent<Interactable>() != null)
			{
				_canInteract = false;
			
			}
		}
	}
}
