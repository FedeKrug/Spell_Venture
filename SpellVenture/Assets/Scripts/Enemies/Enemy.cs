using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game.Enemies
{
	public abstract class Enemy : MonoBehaviour
	{
		[SerializeField] protected float speed;
		[SerializeField] protected float idleDamage, damage;
		[SerializeField] protected Rigidbody2D rb2d;
		[SerializeField] protected Animator anim;
		[SerializeField] protected List<AnimationClip> animations;

		protected abstract void AttackPlayer();

		void Awake()
		{

		}


		void Update()
		{

		}
	}

	public class MiniEnemy : Enemy
	{
		protected override void AttackPlayer()
		{
			//TODO: Make damage and create health system
		}
	}
}
