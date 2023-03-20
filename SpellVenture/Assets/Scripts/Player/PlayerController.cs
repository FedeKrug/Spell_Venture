using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;


namespace Game.Player
{
	public class PlayerController : MonoBehaviour //TODO: Climbing walls mechanic
	{
		[SerializeField] private Rigidbody2D _rb2d;
		[SerializeField] private float jumpForce, speed, speedMultiplier;
		[SerializeField] private PlayerInput _playerInput;
		[SerializeField] private SpriteRenderer _spriteRenderer;
		[SerializeField] private Transform _spellSpawner;
		[SerializeField] private Animator _anim;
		[SerializeField] private List<AnimationClip> _animations;
		private Vector2 _inputVector;

		private InputManager _inputManager;
		private void Awake()
		{
			_inputManager = InputManager.instance;
		}

		private void FixedUpdate()
		{
			_rb2d.velocity = new Vector2(_inputVector.x * speed * Time.fixedDeltaTime, _rb2d.velocity.y);
		}

		

		public void Attack()
		{
			Debug.Log("Player has Attacked"); //Melee Attack
			_anim.Play(_animations[0].ToString()); //Attack Animation
		}

		public void OnMovement(InputValue value)
		{
			Vector2 moveInput = value.Get<Vector2>().normalized;
			_inputVector = new Vector2(moveInput.x * speed * Time.deltaTime, 0);
			if (_inputVector.x > 0)
			{
				if (_inputVector.x == 0 || _inputVector.x > 0)
				{
					//_spriteRenderer.flipX = false;
					Transform playerRot = gameObject.transform;
					playerRot.eulerAngles = new Vector3(0, 0, 0);
					_spellSpawner.eulerAngles = new Vector3(0, 0, 0);
				}
			}
			else if (_inputVector.x < 0)
			{
				if (_inputVector.x == 0 || _inputVector.x < 0)
				{
					Transform playerRot = gameObject.transform;
					playerRot.eulerAngles = new Vector3(0, 180, 0);
					_spellSpawner.eulerAngles = new Vector3(0, 180, 0);

				}

			}
		}
	}

}
