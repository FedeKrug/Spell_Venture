using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

namespace Game.Player
{
	public class BetterJump : MonoBehaviour
	{
		[SerializeField, Range(0, 10)] float _lowJumpMultiplier, _fallMultiplier;

		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField] private Animator _anim;


		public void Jumping()
		{
			//_rb2d.AddForce(Vector2.up * _jumpForce * Time.deltaTime, ForceMode2D.Impulse);
			if (_rb2d.velocity.y < 0)
			{
				_rb2d.velocity += Vector2.up * Physics2D.gravity.y * (_fallMultiplier - 1) * Time.deltaTime;
			}
		}

		public void Salto(InputAction.CallbackContext context)
		{
			if (context.performed)
			{
				Jumping();
			}
		}
	}


}
