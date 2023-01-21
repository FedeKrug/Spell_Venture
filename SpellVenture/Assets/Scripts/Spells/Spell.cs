using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Game.Spells
{
	public class Spell : MonoBehaviour //TODO: Destroy the spells when they choke with anything in the game... and they should be destroyed by using time lapse
	{
		[SerializeField] protected float speed,damage, modifiedDamage;
		[SerializeField] protected bool damageEffect;
		[SerializeField] protected Rigidbody2D _rb2d;
	
		//void Update()
		//{
		//	transform.position += transform.right * speed * Time.deltaTime;

		//}

		private void FixedUpdate()
		{
			_rb2d.AddForce(new Vector2(speed * Time.fixedDeltaTime, _rb2d.position.y));
			//_rb2d.AddForce(Vector2.right * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
		}
	}



}
