using System.Collections;
using System.Collections.Generic;

using Game.Interfaces;

using UnityEngine;

namespace Game.Tutorial
{
	public class TutorialPlank : MonoBehaviour, Interactable
	{
		[SerializeField] private GameObject _tutorialPanel;
		[SerializeField] private bool _isOn;
		private void Update()
		{
			if (_isOn)
			{
				_tutorialPanel.SetActive(true);
			}
			else
			{
				_tutorialPanel.SetActive(false);

			}
		}
		void Interactable.Interact()
		{
			_isOn = !_isOn;
		}
	}

}
