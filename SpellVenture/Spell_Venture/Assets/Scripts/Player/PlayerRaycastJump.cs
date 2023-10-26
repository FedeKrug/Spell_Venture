using UnityEngine;

namespace Game.Player
{
	public class PlayerRaycastJump : MonoBehaviour
	{
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField] private LayerMask _groundLayers;
		[SerializeField, Range(0, 10)] private float _raycastDistance;
		[SerializeField] private KeyCode _jumpKey;
		[SerializeField] private bool _isGrounded;
		[SerializeField] private float _jumpForce;
		[SerializeField] private float _lowJumpMultiplier;
		[SerializeField] private float _fallMultiplier;

		public bool IsGrounded
		{
			get => _isGrounded;
		}

		private void Update()
		{
			RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, _raycastDistance, _groundLayers.value);
			if (hit.collider != null)
			{
				//Debug.Log(hit.collider);
				_isGrounded = true;
			}
			else
			{
				_isGrounded = false;
			}

			if (_isGrounded && Input.GetKeyDown(_jumpKey))
			{
				Jump();
			}

			if (_rb2d.velocity.y < 0) //esta cayendo
			{
				_rb2d.velocity += Vector2.up * Physics2D.gravity.y * (_fallMultiplier - 1) * Time.deltaTime;

			}
			else if (_rb2d.velocity.y > 0 && !Input.GetKey(_jumpKey))
			{
				_rb2d.velocity += Vector2.up * Physics2D.gravity.y * (_lowJumpMultiplier - 1) * Time.deltaTime;
			}
			Debug.DrawRay(transform.position, Vector3.down * _raycastDistance, Color.red);
		}

		public void Jump()
		{
			_rb2d.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
		}

	}
}
