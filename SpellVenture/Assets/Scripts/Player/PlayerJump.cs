using UnityEngine;

namespace Game.Player
{
	public class PlayerJump : MonoBehaviour
	{
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField, Range(0, 100)] private float _jumpForce;

		public void Jump()
		{
			if (Mathf.Abs(_rb2d.velocity.y) < 0.01f)
			{
				_rb2d.velocity = Vector2.up * _jumpForce;

			}
		}

		private void OnJumping()
		{
			Jump();
		}
	}


}
