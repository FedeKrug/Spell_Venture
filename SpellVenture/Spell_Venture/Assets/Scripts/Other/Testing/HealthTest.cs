using UnityEngine;
using Game.Managers;

public class HealthTest : MonoBehaviour
{
	[SerializeField] private float _damage = 10;
	[SerializeField] private float _healAmount = 20;
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.B))
		{
			GameManager.instance.TakeDamage(_damage);
			Debug.Log("Take damage");
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			GameManager.instance.Heal(_healAmount);
			Debug.Log("Heal");
		}
	}
}
