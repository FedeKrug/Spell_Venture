using UnityEngine;
using Game.Interfaces;
using Game.Managers;

public class Coin : Collectable
{
	[SerializeField] private int _points;

	public void Collected()
	{

	}
}
public class HealthBoost : Collectable
{
	[SerializeField] private int _healthPoints;
	public void Collected()
	{
		GameManager.instance.Heal(_healthPoints);
	}
}
