using Game.Interfaces;
using Game.Managers;

using UnityEngine;

namespace Game.Tutorial
{
	public class TutorialPlank : MonoBehaviour, Interactable
	{
		[SerializeField] private GameObject _tutorialPanel;
		[SerializeField] private bool _isOn;
		private bool _playerInZone;
		private void Update()
		{
			if (!_playerInZone) return;
			if (_isOn)
			{
				_tutorialPanel.SetActive(true);
				GameManager.instance.canMove = false;
			}
			else if (!_isOn)
			{
				_tutorialPanel.SetActive(false);
				GameManager.instance.canMove = true;

			}
		}
		void Interactable.Interact()
		{
			_isOn = !_isOn;
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			_playerInZone = true;
		}
		private void OnTriggerExit2D(Collider2D collision)
		{
			_playerInZone = false;

		}
	}

}
