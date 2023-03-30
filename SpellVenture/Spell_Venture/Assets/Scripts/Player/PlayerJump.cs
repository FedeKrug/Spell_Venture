
using UnityEngine;


namespace Game.Player
{
	public class PlayerJump : MonoBehaviour
	{
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField] private float _jumpForce;
		[SerializeField, Tooltip("Jump Button name")] private string _jumpButton;
		private void Update()
		{
			if (Input.GetButtonDown(_jumpButton))
			{
				Jump();
			}

		}

		private void Jump()
		{
			_rb2d.velocity = new Vector2(_rb2d.velocity.x, _jumpForce);
		}
	}
}
