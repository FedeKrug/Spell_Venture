using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
	Rigidbody2D rb2d;
	[SerializeField] float jumpForce, speed;

	private void Awake()
	{
		rb2d = GetComponentInChildren<Rigidbody2D>();
	}
	public void Movement(InputAction.CallbackContext context)
	{
		var contexto = context.ReadValue<Vector2>(); //solo se llama cuando el value cambia
		if (context.performed)
		{
			rb2d.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.fixedDeltaTime, rb2d.velocity.y, this.transform.position.z);

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
		if (context.performed && Mathf.Abs(rb2d.velocity.y) < 0.01f)
		{
			rb2d.AddForce(Vector2.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);

		}


	}
}
