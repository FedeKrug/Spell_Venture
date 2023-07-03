
using UnityEngine;


namespace Game.Player
{
	public class PlayerProxy : MonoBehaviour
	{
		[SerializeField] private PlayerMovement _playerRef;
		[SerializeField] private PlayerMeleeAttack _meleeAttack;
		public void Attack(float damage)
		{
			_meleeAttack.OnAttack(damage);
		}
		public void OnEndAttack()
		{
			_meleeAttack.ResetAnimationTrigger();
		}

	}
}
