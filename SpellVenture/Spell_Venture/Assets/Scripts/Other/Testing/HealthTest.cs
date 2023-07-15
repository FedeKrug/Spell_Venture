using System.Collections;
using System.Collections.Generic;
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
			PlayerManager.instance.TakeDamage(_damage);
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			PlayerManager.instance.Heal(_healAmount);
		}
	}
}
