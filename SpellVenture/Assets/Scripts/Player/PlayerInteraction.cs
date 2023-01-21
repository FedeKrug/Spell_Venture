using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Objects;
namespace Game.Player
{
	public class PlayerInteraction : MonoBehaviour
	{

		[SerializeField] private Transform _interactableDetector;
		[SerializeField] private float _rayDistance;
		[SerializeField] private GameObject _keyToInteractUI;
		[SerializeField] private bool interactable;
		[SerializeField] private LayerMask _interactableLayers;
		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.GetComponent<Interactable>() != null)
			{
				Debug.Log("This object is interactable");
				interactable = true;
			}
		}
		private void OnTriggerExit2D(Collider2D collision)
		{
			if (collision.GetComponent<Interactable>() != null)
			{
				Debug.Log("There are no interactions");
				interactable = false;
			}
		}

		public void OnInteract()
		{

			if (!interactable)
			{
				Debug.LogError("Player can't interact with this");
				return;
			}
			Debug.Log("Player is interacting");
			Objeto.instance.GetComponent<Interactable>();

			if (Objeto.instance.GetComponent<Interactable>() != null)
			{
				Debug.Log("Player can interact with this object");
				Objeto.instance.GetComponent<Interactable>().Interact();
			}
		}
	}

}
