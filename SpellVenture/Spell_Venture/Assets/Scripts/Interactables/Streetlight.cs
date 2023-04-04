
using UnityEngine;
using Game.Interfaces;

public class Streetlight : MonoBehaviour, Interactable
{
	[SerializeField] private Light _lampLight;
	[SerializeField] private Color _offColor, _onColor;
	[SerializeField] private bool _isOn;
	[SerializeField] private SpriteRenderer _spriteR;
	private void Update()
	{
		if (_isOn)
		{
			//_lampLight.enabled = true;
			_spriteR.color = _onColor;
		}
		else
		{
			_spriteR.color = _offColor;
			//_lampLight.enabled = false;

		}
	}
	public void Interact()
	{
		_isOn = !_isOn;
	}
}