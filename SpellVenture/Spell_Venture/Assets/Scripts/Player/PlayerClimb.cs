using UnityEngine;

namespace Game.Player
{
	public class PlayerClimb : MonoBehaviour
	{
		[Header("Components")]
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField] private Animator _anim;
		[SerializeField] private BoxCollider2D _collider2D;
		[SerializeField] private PlayerRaycastJump _playerJumpRef;
		[Header("Speed")]
		[SerializeField] private float _climbingSpeed;
		private float _initialGravity;
		private bool _isClimbing;
		private Vector2 _input;

		private void Start()
		{
			_initialGravity = _rb2d.gravityScale;

		}
		private void Update()
		{
			_input.y = Input.GetAxisRaw("Vertical");
		}

		private void FixedUpdate()
		{
			Climb();
		}
		private void Climb()
		{
			if ((_input.y != 0 || _isClimbing) && _collider2D.IsTouchingLayers(LayerMask.GetMask("Ladder")))
			{
				Vector2 climbSpeed = new Vector2(_rb2d.velocity.x, _input.y * _climbingSpeed);
				_rb2d.velocity = climbSpeed;
				_rb2d.gravityScale = 0;
				_isClimbing = true;
			}
			else
			{
				_rb2d.gravityScale = _initialGravity;
				_isClimbing = false;
			}
			if (_playerJumpRef.IsGrounded)
			{
				_isClimbing = false;
			}

		}

	}

}
