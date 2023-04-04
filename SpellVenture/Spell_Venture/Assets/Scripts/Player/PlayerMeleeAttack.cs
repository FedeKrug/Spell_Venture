
using UnityEngine;
using System.Collections;

namespace Game.Player
{
	public class PlayerMeleeAttack : MonoBehaviour
	{
		[SerializeField] private Animator _anim;
		[SerializeField] private AnimationClip _attackAnimation;
		[SerializeField] private KeyCode _attackKey;
		[SerializeField] private float _animationTime;
		private void Update()
		{
			if (Input.GetKeyDown(_attackKey))
			{
				_anim.SetBool("Attacking", true);
				StartCoroutine(Attack());
			}
		}
		IEnumerator Attack()
		{
			
			yield return new WaitForSeconds(_animationTime);
			_anim.SetBool("Attacking", false);
		}

	}
}
