using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
	[SerializeField] private GameObject _spellsSpawner;
	[SerializeField] private GameObject _spell;


	public void Attack()
	{
		Debug.Log("Player has Attacked");
		//TODO: improve attack with animations and game feel and add damage & health.

	}
	private void OnAttack()
	{
		Attack();
	}
}
