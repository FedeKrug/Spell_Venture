using System.Collections;

using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamagable
{
	[SerializeField] private float _maxHealth;
	private float _health;

	private void Start()
	{
		_health = _maxHealth;
	}

	public void TakeDamage(float damage)
	{
		_health -= damage;
		CheckDeath();
		DamagedFeedback();
	}

	private void CheckDeath()
	{
		if (_health <= 0)
		{
			Die();
		}
	}

	private void Die()
	{
		//Debug.Log("Die()");
		StartCoroutine(CO_Death());
	}
	private IEnumerator CO_Death()
	{
		yield return null;
		Debug.Log("Death or animation ?? ");
		gameObject.SetActive(false);
	}

	public void DamagedFeedback()
	{
		//TODO: Animation or particles or change material emmisive ??
	}
}
