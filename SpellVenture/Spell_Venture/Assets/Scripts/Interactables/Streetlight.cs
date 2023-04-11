
using UnityEngine;
using Game.Interfaces;

public class Streetlight : MonoBehaviour, Interactable
{
	[SerializeField] private GameObject _lampLight;
	[SerializeField] private bool _isOn;
	private void Update()
	{
		if (_isOn)
		{
			_lampLight.SetActive(true);
		}
		else
		{

			_lampLight.SetActive(false);

		}
	}
	public void Interact()
	{
		_isOn = !_isOn;
	}
}