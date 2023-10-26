using UnityEngine;

namespace Game.Managers
{
    [DefaultExecutionOrder(-20)]

    public class GameManager : MonoBehaviour
    {
        [SerializeField] private FloatSO _playerHealth;
        [SerializeField] private float _maxHealth;
        [SerializeField] private int _coinScore;

        public static GameManager instance;
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

        public float MaxHealth
        {
            get => _maxHealth;
            set => _maxHealth = value;
        }
        public FloatSO PlayerHealth
        {
            get => _playerHealth;
            set => _playerHealth = value;
        }

        public void TakeDamage(float damage)
        {
            _playerHealth.value -= damage;
            UIManager.instance.UpdateHealthBar();
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