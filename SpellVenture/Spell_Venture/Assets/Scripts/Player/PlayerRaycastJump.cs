
using UnityEngine;


namespace Game.Player
{
	public class PlayerRaycastJump : MonoBehaviour
	{
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField, Range(0,10)] private float _raycastDistance;
		[SerializeField] private KeyCode _jumpKey;
		[SerializeField] private bool _isGrounded;
		[SerializeField] private float _jumpForce;
		[SerializeField] private float _lowJumpMultiplier;
		[SerializeField] private float _fallMultiplier;

		private void Update()
		{
			RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, _raycastDistance);
			Debug.DrawRay(transform.position, new Vector3(_raycastDistance,0,0)  , Color.red);
			if (hit.collider != null)
			{
				_isGrounded = true;
			}
			else
			{
				_isGrounded = false;
			}
			
			if (_isGrounded && Input.GetKey(_jumpKey))
			{
				Jump();
			}

			if (_rb2d.velocity.y < 0) //esta cayendo
			{
				_rb2d.velocity += Vector2.up * Physics2D.gravity.y * (_fallMultiplier - 1) * Time.deltaTime;

			}
			else if (_rb2d.velocity.y > 0 && !Input.GetKey(_jumpKey) || (Input.GetKey(_jumpKey) && !_isGrounded)) 
			{
				_rb2d.velocity += Vector2.up * Physics2D.gravity.y * (_lowJumpMultiplier - 1) * Time.deltaTime;
			}
		}

		public void Jump()
		{
			_rb2d.velocity = new Vector2(_rb2d.velocity.x, _jumpForce);
		}

	}
}
