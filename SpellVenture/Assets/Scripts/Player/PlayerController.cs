using UnityEngine;
using System.Collections.Generic;
using UnityEngine.InputSystem;


namespace Game.Player
{
	public class PlayerController : MonoBehaviour
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

		public void Interact(InputAction.CallbackContext context)
		{
			if (context.performed) //cuando el context es presionado
			{
				Debug.Log("Interactua");
			}
		}

		////public void Jumping(InputAction.CallbackContext context)
		//{
		//	if (context.performed && Mathf.Abs(_rb2d.velocity.y) < 0.01f)
		//	{
		//		_rb2d.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);

		//	}


		//}

		private void Saltar()
		{
			if (Mathf.Abs(_rb2d.velocity.y) < 0.01f)
			{
				_rb2d.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);

			}
			//Debug.Log("Player has Jumped"); 
		}

		public void Attack()
		{
			Debug.Log("Player has Attacked"); //Melee Attack
			_anim.Play(_animations[0].ToString()); //Attack Animation

		}

		public void OnMovement(InputValue value)
		{
			Vector2 moveInput = value.Get<Vector2>();
			_inputVector = new Vector2(moveInput.x * speed * Time.deltaTime, 0);
			if (_inputVector.x > 0)
			{
				if (_inputVector.x == 0 || _inputVector.x > 0)
				{
					//_spriteRenderer.flipX = false;
					Transform playerRot = gameObject.transform;
					playerRot.eulerAngles = new Vector3(0, 180, 0);
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
			//Debug.Log("Player has Moved");
			//Debug.Log(moveInput + " " +
			//_inputVector + "Input Vector");

		}

		private void OnJumping()
		{
			Saltar();
			//TODO: Improve jumping using regulable jump (check out the video about Celeste's jumping)
		}


	}

}
