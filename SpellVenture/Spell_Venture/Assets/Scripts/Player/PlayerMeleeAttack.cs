
using UnityEngine;
using System.Collections;

namespace Game.Player
{
	public class PlayerMeleeAttack : MonoBehaviour
	{
		[Header("Animations")]
		[SerializeField] private Animator _anim;
		[SerializeField] private string _attackAnimationParam;
		
		[Space(10)]
		[Header("Features")]
		[SerializeField] private KeyCode _attackKey;
		[SerializeField] private float _attackCooldown; //TODO: Improve the melee attack to be more like Hollow Knight.
		[Space(10)]
		[Header("Positions")]
		[SerializeField] private Transform _attackObjectPosition;
		[SerializeField] private float _attackRange;


		
		private void Update()
		{
			if (Input.GetKeyDown(_attackKey))
			{
				_anim.SetTrigger(_attackAnimationParam);
			}
		}
		public void OnAttack(float damage)
		{
			//Debug.Log($"Player attacked with a damage of {damage}");
			Collider2D [] catchedStuff = Physics2D.OverlapCircleAll(_attackObjectPosition.position,_attackRange);
			foreach (Collider2D enemyCatched in catchedStuff)
			{
				var catchedEnemy = enemyCatched.GetComponent<IDamagable>();
				if (catchedEnemy!=null)
				{
					catchedEnemy.TakeDamage(damage);
				}
			}

		}
		public void ResetAnimationTrigger()
		{
			_anim.ResetTrigger(_attackAnimationParam);
		}
	}
}
