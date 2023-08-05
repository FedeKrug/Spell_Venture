using UnityEngine;

namespace Game.Managers
{
	[DefaultExecutionOrder(-20)]

	public class PlayerManager : MonoBehaviour
	{
		[SerializeField] private FloatSO _playerHealth;
		[SerializeField] private float _maxHealth;
		[SerializeField] private int _coinScore;

		public static PlayerManager instance;
		private void Awake()
		{
			if (instance == null)
			{
				instance = this;
			}
			else
			{
				Destroy(gameObject);
			}
		}

		private void Start()
		{
			_playerHealth.value = _maxHealth;
		}
		public bool canMove;

		public void TakeDamage(float damage)
		{
			_playerHealth.value -= damage;
			CheckDeath();
		}
		public void Heal(float healAmount)
		{
			_playerHealth.value += healAmount;
			CheckMaxHealth();
		}

		private void CheckDeath()
		{
			if (_playerHealth.value <= 0)
			{
				Debug.Log($"Player is dead. TODO: agregar feedback de muerte");
				canMove = false;
			}
		}


		private void CheckMaxHealth()
		{
			if (_playerHealth.value > _maxHealth)
			{
				_playerHealth.value = _maxHealth;
			}
		}

	}
}