using Game.Managers;
using UnityEngine;


namespace Game.Player
{
	public class PlayerMovement : MonoBehaviour
	{
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField] private float _minMovementSpeed, _maxMovementSpeed;
		[SerializeField] private string _horizontalAxis;
		private Vector2 _moveInput;
		private float _movementSpeed;

		private bool _canMove;

		private void Start()
		{
			_movementSpeed = _minMovementSpeed;
		}
		
		private void Update()
		{
			_canMove = PlayerManager.instance.canMove;
			_moveInput = new Vector2(Input.GetAxisRaw(_horizontalAxis), 0).normalized;
			if (_canMove)
			{
				if (_moveInput.x > 0)
				{
					transform.eulerAngles = new Vector3(0, 0, 0);
				}
				else if (_moveInput.x < 0)
				{
					transform.eulerAngles = new Vector3(0, 180, 0);

				}
				if ((Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)))
				{
					_movementSpeed = _maxMovementSpeed;
				}
				else if ((Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift)))
				{
					_movementSpeed = _minMovementSpeed;
				}
			}

		}
		private void FixedUpdate()
		{
			if (_canMove) Movement();
		}

		private void Movement()
		{
			_rb2d.velocity += _moveInput * _movementSpeed * Time.fixedDeltaTime;
		}
	}

}
