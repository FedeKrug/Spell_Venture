using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private Rigidbody2D _rb2d;
	[SerializeField] private float jumpForce, speed;
	[SerializeField] private PlayerInput _playerInput;
	private Vector2 _inputVector;

	private InputManager _inputManager;
	private void Awake()
	{
		_inputManager = InputManager.instance;	
	}

	

	public void Movement(InputAction.CallbackContext context)
	{
		var contexto = context.ReadValue<Vector2>(); //solo se llama cuando el value cambia
		if (context.performed)
		{
			_rb2d.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.fixedDeltaTime, _rb2d.velocity.y, this.transform.position.z);

		}
		Debug.Log(contexto);
	}
	public void Interact(InputAction.CallbackContext context)
	{
		if (context.performed) //cuando el context es presionado
		{
			Debug.Log("Interactua");
		}
	}
	public void Jumping(InputAction.CallbackContext context)
	{
		if (context.performed && Mathf.Abs(_rb2d.velocity.y) < 0.01f)
		{
			_rb2d.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);

		}

		
	}

	public void Attack()
	{
		Debug.Log("Player has Attacked");
		//TODO: improve attack with animations and game feel.
	}


	public void OnMovement(InputValue value)
	{
		Vector2 moveInput = value.Get<Vector2>();
		_inputVector = new Vector2(moveInput.x,0);
		Debug.Log("Player has Moved");

	}


	private void OnAttack(InputValue value)
	{
		Attack();
	}

	private void OnInteract()
	{
		Debug.Log("Player has Interacted");

	}
}
