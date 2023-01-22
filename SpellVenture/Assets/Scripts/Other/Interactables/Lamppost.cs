using UnityEngine;

namespace Game.Objects
{
	public class Lamppost : MonoBehaviour, Interactable
	{
		[SerializeField] private bool _isActive;
		[SerializeField] private SpriteRenderer _spRef;
		
		

		public void Interact()
		{
			_isActive = !_isActive;

			if (_isActive)
			{
				_spRef.color = Color.blue;
			}
			else
			{
				_spRef.color = Color.yellow;

			}
		}
	}

}